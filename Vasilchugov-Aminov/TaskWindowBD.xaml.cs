using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для TaskWindowBD.xaml
    /// </summary>
    public partial class TaskWindowBD : Window
    {
        public TaskWindowBD()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
