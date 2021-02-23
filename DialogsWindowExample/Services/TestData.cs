using DialogsWindowExample.Models;
using System;
using System.Linq;

namespace DialogsWindowExample.Services
{
    static class TestData
    {
        public static Group[] Groups { get; } = Enumerable.Range(1, 10)
           .Select(i => new Group { Id =1, Name = $"Группа {i}", Description ="тест" })
           .ToArray();

        public static Student[] Students { get; } = CreateStudents(Groups);

        private static Student[] CreateStudents(Group[] groups)
        {
            var rnd = new Random();
            var index = 1;
            foreach (var group in groups)
                for (var i = 0; i < 10; i++)
                    group.Students.Add(new Student
                    {
                        Name = $"Имя {index}",
                        Surname = $"Фамилия {index}",
                        Patronymic = $"Отчество {index++}",
                        Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(300 * rnd.Next(19, 30))),
                        Rating = rnd.NextDouble() * 100
                    });

            return groups.SelectMany(g => g.Students).ToArray();
        }
    }
}
