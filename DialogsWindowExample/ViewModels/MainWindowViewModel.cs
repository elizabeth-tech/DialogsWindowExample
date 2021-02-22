using Covid19.ViewModels.Base;

namespace DialogsWindowExample.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel() { }

        #region Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string title = "Деканат";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => title;
            set => Set(ref title, value);
        }

        #endregion
    }
}
