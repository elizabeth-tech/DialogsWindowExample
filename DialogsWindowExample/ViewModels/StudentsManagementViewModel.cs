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

        /// <summary>Заголовок окна</summary>
        private Group selectedGroup;

        /// <summary>Заголовок окна</summary>
        public Group SelectedGroup
        {
            get => selectedGroup;
            set => Set(ref selectedGroup, value);
        }

        #endregion
    }
}
