﻿using Microsoft.Win32;
using NLog;
using System;
using System.Text;
using System.Windows;
namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        //настройки
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Settings taskWindow = new Settings();
            taskWindow.Show();
        }
        //о программе
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Программа пока непонятно о чём");
            sb.AppendLine("Сделана двумя студентами из группы 9ИСП-391к-17");
            sb.AppendLine("Создатели: ");
            sb.AppendLine("Аминов В.Т");
            sb.AppendLine("Васильчугов Н.А");
            sb.AppendLine("Наша ссылка на GitHub:");
            sb.AppendLine("https://github.com/Nikitabeepbeep/Praktika-2.0");
            MessageBox.Show(sb.ToString());
        }
        //очистить
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поле отображения  очищено!");
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {

        }
        //присоединение к базе данных
        private void Baza_dannyx(object sender, RoutedEventArgs e)
        {
            DBConnectionForm taskWindow = new DBConnectionForm();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
        private void newbutton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    kekk.Items.Add(System.IO.Path.GetFileName(filename));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   

        }
    }
}

