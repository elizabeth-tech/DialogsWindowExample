using DialogsWindowExample.Models;
using System;
using System.Collections.Generic;

namespace DialogsWindowExample.Services
{
    class StudentsManager
    {
        private readonly StudentsRepository students;
        private readonly GroupsRepository groups;

        public StudentsManager(StudentsRepository students, GroupsRepository groups)
        {
            this.students = students;
            this.groups = groups;
        }

        public IEnumerable<Student> Students => students.GetAll();

        public IEnumerable<Group> Groups => groups.GetAll();

        // Выполняем сохранение изменений внутри репозитория
        public void Update(Student Student) => students.Update(Student.Id, Student);

        // Создаем нового студента в определенной группе
        public bool Create(Student student, string groupName)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));
            if (string.IsNullOrWhiteSpace(groupName)) throw new ArgumentException("Некорректное имя группы", nameof(groupName));

            var group = groups.Get(groupName); // Ищем в репозитории группу с указанным именем
            if (group is null) // Если такой группы нет, то создаем ее
            {
                group = new Group { Name = groupName };
                groups.Add(group);
            }
            group.Students.Add(student);
            students.Add(student);
            return true;
        }
    }
}
