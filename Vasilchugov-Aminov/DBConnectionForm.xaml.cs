using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для DBConnectionForm.xaml
    /// </summary>
    public partial class DBConnectionForm : Window
    {
        public DBConnectionForm()
        {
            InitializeComponent();
        }
        //сервер
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //имя БД
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        //имя пользователя
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        //пароль
        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
        //закрыть
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //соединение c БД
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string datasource = serverBox.Text;
            string database = dbNameBox.Text;
            string username = usernameBox.Text ?? "";
            string userpass = userpassBox.Text ?? "";
            //обработка ошибок при подключении к БД
            if (string.IsNullOrEmpty(datasource) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(database) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(userpass) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                return;
            }
            if (DBConnectionService.SetSqlConnection(GetDBConnectionString(datasource, database, username, userpass)))
            {
                MessageBox.Show("Успешное подключение!", "Соединение успешно!", MessageBoxButton.OK);
                this.Close();
            }
        }
        public string GetDBConnectionString(string datasource, string database, string username, string password)
        {
            string dataSourceStirng = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;";
            if (!string.IsNullOrEmpty(username))
            {
                dataSourceStirng += "User ID=" + username + ";Password=" + password + ";";
            }
            else
            {
                dataSourceStirng += "Integrated Security=SSPI;";
            }
            return dataSourceStirng;
        }
    }
}
