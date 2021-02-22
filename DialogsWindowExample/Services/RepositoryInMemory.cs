using DialogsWindowExample.Models;
using System;
using System.Collections.Generic;

namespace DialogsWindowExample.Services
{
    abstract class RepositoryInMemory<T> : IRepository<T> where T : IEntity
    {
        // Хранилище работает на основе списка
        private List<T> items = new List<T>();

        private int lastId;

        #region Конструкторы

        protected RepositoryInMemory() { }

        protected RepositoryInMemory(IEnumerable<T> items)
        {
            foreach (var item in items)
                Add(item);
        }

        #endregion

        public void Add(T item)
        {
            // Проверяем, что добавляемый элемент не пустой и что такого элемента еще нет в списке
            if (item is null) throw new ArgumentNullException(nameof(item));
            if (items.Contains(item)) return;

            item.Id = ++lastId;
            items.Add(item);
        }

        public IEnumerable<T> GetAll() => items;

        public bool Remove(T item) => items.Remove(item);

        public void Update(int id, T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "Индекс не может быть меньше 1!");

            // Если такой элемент уже есть, то обновлять не надо, ибо он уже обновлен
            if (items.Contains(item)) return;

            // Пытаемся извлечь объект из репозитория
            var db_item = ((IRepository<T>)this).Get(id);
            if (db_item is null)
                throw new InvalidOperationException("Редактируемый элемент не найден в репозитории");

            Update(item, db_item);
        }

        protected abstract void Update(T Source, T Destination);
    }
}
