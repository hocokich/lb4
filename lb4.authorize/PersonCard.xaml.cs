using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lb4.authorize
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class PersonCard : UserControl
    {
        public PersonCard()
        {
            InitializeComponent();

            login.TextChanged += login_TextChanged; // назначение обработчика изменения логина 
            pass.TextChanged += pass_TextChanged; // назначение обработчика изменения пароля

            ok.Click += ok_Click;
        }

        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
         "login", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(PersonCard), // тип данных элемента управления
         new PropertyMetadata(null, LoginChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра
        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }
        private static void LoginChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.login.Text = loginForm.Login;
        }
        private void validateData()
        {
            // длина логина должна быть не менее 4 символов,
            // а длина пароля - не менее 8 символов
            bool isDataValid = login.Text.Length >= 4 && pass.Text.Length >= 8;

            if (isDataValid)
                ok.IsEnabled = true;
            else
                ok.IsEnabled = false;
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
