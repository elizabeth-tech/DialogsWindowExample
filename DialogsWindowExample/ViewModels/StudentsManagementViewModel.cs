using Covid19.ViewModels.Base;

namespace DialogsWindowExample.ViewModels
{
    class StudentsManagementViewModel : ViewModel
    {
        public StudentsManagementViewModel()
        {

        }

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
    }
}
