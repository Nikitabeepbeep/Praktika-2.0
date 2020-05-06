using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using NLog;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для DBConnectionForm.xaml
    /// </summary>
    public partial class DBConnectionForm : Window
    { 
        private static Logger logger = LogManager.GetCurrentClassLogger();
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
            logger.Info("Моудль подключения к БД закрыт");
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
                logger.Error("Пожалуйста,заполните поля!", "Ошибка соединения!");
                return;
            }
            if (string.IsNullOrEmpty(database) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                logger.Error("Пожалуйста,заполните поля!", "Ошибка соединения!");
                return;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                logger.Error("Пожалуйста,заполните поля!", "Ошибка соединения!");
                return;
            }
            if (string.IsNullOrEmpty(userpass) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста,заполните поля!", "Ошибка соединения!", MessageBoxButton.OK);
                logger.Error("Пожалуйста,заполните поля!", "Ошибка соединения!");
                return;
            }
            if
                (DBConnectionService.DBConnectionService.SetSqlConnection(GetDBConnectionString(datasource, database, username, userpass)))
            {
                MessageBox.Show("Успешное подключение!", "Соединение успешно!", MessageBoxButton.OK);
                logger.Info("Успешное подключение");
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
