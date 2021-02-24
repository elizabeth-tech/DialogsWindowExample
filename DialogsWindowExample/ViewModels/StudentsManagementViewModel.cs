using Covid19.Infrastructure.Commands;
using Covid19.ViewModels.Base;
using DialogsWindowExample.Models;
using DialogsWindowExample.Services;
using DialogsWindowExample.Services.Interfaces;
using System.Collections.Generic;
using System.Windows.Input;

namespace DialogsWindowExample.ViewModels
{
    class StudentsManagementViewModel : ViewModel
    {
        public StudentsManagementViewModel(StudentsManager studentsManager, IUserDialogService userDialog)
        {
            this.studentsManager = studentsManager;
            this.userDialog = userDialog;
        }

        private readonly StudentsManager studentsManager;
        private readonly IUserDialogService userDialog;

        public IEnumerable<Student> students => studentsManager.Students;

        public IEnumerable<Group> groups => studentsManager.Groups;

        #region Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string title = "Студенты";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => title;
            set => Set(ref title, value);
        }

        #endregion

        #region Выбранная группа студентов

        /// <summary>Выбранная группа студентов</summary>
        private Group selectedGroup;

        /// <summary>Выбранная группа студентов</summary>
        public Group SelectedGroup
        {
            get => selectedGroup;
            set => Set(ref selectedGroup, value);
        }

        #endregion

        #region Выбранный студент

        /// <summary>Выбранный студент</summary>
        private Student selectedStudent;

        /// <summary>Выбранный студент</summary>
        public Student SelectedStudent
        {
            get => selectedStudent;
            set => Set(ref selectedStudent, value);
        }

        #endregion

        #region Команды

        #region Команда редактирования студента

        private ICommand editStudentCommand;

        /// <summary>Команда редактирования студента</summary>
        public ICommand EditStudentCommand => editStudentCommand ??= new ActionCommand(OnEditStudentCommandExecuted, CanEditStudentCommandExecute);

        private static bool CanEditStudentCommandExecute(object p) => p is Student;

        private void OnEditStudentCommandExecuted(object p)
        {
            if (userDialog.Edit(p))
            {
                studentsManager.Update((Student)p);
                userDialog.ShowInformation("Студент отредактирован", "Деканат");
            }
            else
                userDialog.ShowInformation("Отказ от редактирования", "Деканат");
        }

        #endregion

        #region Команда создания студента

        /// <summary>Создание студента</summary>
        private ICommand createNewStudentCommand;

        /// <summary>Создание студента</summary>
        public ICommand CreateNewStudentCommand => createNewStudentCommand ??= new ActionCommand(OnCreateNewStudentCommandExecuted, CanCreateNewStudentCommandExecute);

        private static bool CanCreateNewStudentCommandExecute(object p) => p is Group;

        private void OnCreateNewStudentCommandExecuted(object p)
        {
            var group = (Group)p;
            Student student = new Student();

            if (!userDialog.Edit(student) || studentsManager.Create(student, group.Name))
            {
                OnPropertyChanged(nameof(students)); // уведомляем, что изменилась коллекция студентов
                return;
            }

            if (userDialog.Confirm("Не удалось создать студента. Повторить?", "Менеджер студентов"))
                OnCreateNewStudentCommandExecuted(p);
        }

        #endregion

        #endregion
    }
}
