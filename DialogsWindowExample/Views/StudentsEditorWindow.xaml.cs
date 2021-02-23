using System;
using System.ComponentModel;
using System.Windows;

namespace DialogsWindowExample.Views
{
    public partial class StudentsEditorWindow : Window
    {
        #region Имя

        // Свойство зависимости
        public static readonly DependencyProperty FirstNameProperty = DependencyProperty.Register(
                nameof(FirstName),
                typeof(string),
                typeof(StudentsEditorWindow),
                new PropertyMetadata(null));

        public string FirstName { get => (string)GetValue(FirstNameProperty); set => SetValue(FirstNameProperty, value); }

        #endregion

        #region Фамилия

        /// <summary>Фамилия</summary>
        public static readonly DependencyProperty LastNameProperty = DependencyProperty.Register(
                nameof(LastName),
                typeof(string),
                typeof(StudentsEditorWindow),
                new PropertyMetadata(default(string)));

        /// <summary>Фамилия</summary>
        [Description("Фамилия")]
        public string LastName { get => (string)GetValue(LastNameProperty); set => SetValue(LastNameProperty, value); }

        #endregion

        #region Отчество

        /// <summary>Отчество</summary>
        public static readonly DependencyProperty PatronymicProperty = DependencyProperty.Register(
                nameof(Patronymic),
                typeof(string),
                typeof(StudentsEditorWindow),
                new PropertyMetadata(default(string)));

        /// <summary>Отчество</summary>
        [Description("Отчество")]
        public string Patronymic { get => (string)GetValue(PatronymicProperty); set => SetValue(PatronymicProperty, value); }

        #endregion

        #region Оценка

        /// <summary>Оценка</summary>
        public static readonly DependencyProperty RatingProperty = DependencyProperty.Register(
                nameof(Rating),
                typeof(double),
                typeof(StudentsEditorWindow),
                new PropertyMetadata(default(double)));

        /// <summary>Оценка</summary>
        [Description("Оценка")]
        public double Rating { get => (Double)GetValue(RatingProperty); set => SetValue(RatingProperty, value); }

        #endregion

        #region Дата рождения

        /// <summary>Дата рождения</summary>
        public static readonly DependencyProperty BirthdayProperty = DependencyProperty.Register(
                nameof(Birthday),
                typeof(DateTime),
                typeof(StudentsEditorWindow),
                new PropertyMetadata(default(DateTime)));

        /// <summary>Дата рождения</summary>
        [Description("Дата рождения")]
        public DateTime Birthday { get => (DateTime)GetValue(BirthdayProperty); set => SetValue(BirthdayProperty, value); }

        #endregion

        public StudentsEditorWindow() => InitializeComponent();
    }
}
