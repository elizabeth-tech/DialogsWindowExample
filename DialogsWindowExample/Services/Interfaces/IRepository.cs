using DialogsWindowExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace DialogsWindowExample.Services
{
    interface IRepository<T> where T : IEntity 
    {
        // Добавление некой сущности в репозиторий
        void Add(T item);

        // Удаление
        bool Remove(T item);

        // Обновление состояния
        void Update(int id, T item);

        // Извлечение некой сущности (базовая реализация интерфейса)
        T Get(int id) => GetAll().FirstOrDefault(item => item.Id == id);

        // Получить все сущности
        IEnumerable<T> GetAll();
    }
}
