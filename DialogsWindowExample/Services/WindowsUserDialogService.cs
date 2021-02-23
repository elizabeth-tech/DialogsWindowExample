using DialogsWindowExample.Models;
using DialogsWindowExample.Services.Interfaces;
using DialogsWindowExample.Views;
using System;
using System.Windows;

namespace DialogsWindowExample.Services
{
    class WindowsUserDialogService : IUserDialogService
    {
        public bool Edit(object item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            switch (item)
            {
                default: throw new NotSupportedException($"Редактирование объекта типа {item.GetType().Name} не поддерживается!");
                case Student student:
                    return EditStudent(student);
            }
        }

        public bool Confirm(string message, string caption, bool exclamation = false) =>
            MessageBox.Show(
                message,
                caption,
                MessageBoxButton.YesNo,
                exclamation ? MessageBoxImage.Exclamation : MessageBoxImage.Question)
            == MessageBoxResult.Yes;

        public void ShowError(string message, string caption) =>
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);


        public void ShowInformation(string information, string caption) =>
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);

        public void ShowWarning(string message, string caption) =>
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Warning);

        private static bool EditStudent(Student student)
        {
            // Создаем диалоговое окно и заполняем данными студента, которого выбрали
            var dlg = new StudentsEditorWindow
            {
                FirstName = student.Name,
                LastName = student.Surname,
                Patronymic = student.Patronymic,
                Birthday = student.Birthday,
                Rating = student.Rating
            };
            if (dlg.ShowDialog() != true) return false;

            // Если пользователь подтвердил изменения
            student.Name = dlg.FirstName;
            student.Surname = dlg.LastName;
            student.Patronymic = dlg.Patronymic;
            student.Rating = dlg.Rating;
            student.Birthday = dlg.Birthday;

            return true;
        }
    }
}
