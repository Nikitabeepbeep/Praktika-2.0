﻿using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            sb.AppendLine("Данную программу сделали студенты группы 9ИСП-391к-17:");
            sb.AppendLine("Аминов В.Т и Васильчугов Н.А");
            sb.AppendLine("Руководители практики:");
            sb.AppendLine("Лебедев В.Н");
            sb.AppendLine("Гурьянова С.В");
            sb.AppendLine("Кашина М.А");
            MessageBox.Show(sb.ToString());
        }
        //очистить
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поле отображения  очищено!");

        }
        //присоединение к базе данных
        private void Baza_dannyx(object sender, RoutedEventArgs e)
        {
            DBConnectionForm taskWindow = new DBConnectionForm();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
        //чтение текста из файла
        private void newbutton1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
        }
        //открытие изображения
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        { 
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                kek.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
        //текстбокс
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //mp3 плеер
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MP3_PLAYER taskWindow = new MP3_PLAYER();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
        //выход из приложения
        private void exit_CLick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        //сайт
        private void Application_NavigationFailed(object sender,
      RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/Nikitabeepbeep/Praktika-2.0");

        }
    }
    }


