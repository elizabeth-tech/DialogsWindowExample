using Covid19.ViewModels.Base;
using DialogsWindowExample.Models;
using DialogsWindowExample.Services;
using System.Collections.Generic;

namespace DialogsWindowExample.ViewModels
{
    class StudentsManagementViewModel : ViewModel
    {
        public StudentsManagementViewModel(StudentsManager studentsManager) => this.studentsManager = studentsManager;

        private readonly StudentsManager studentsManager;

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
    }
}
