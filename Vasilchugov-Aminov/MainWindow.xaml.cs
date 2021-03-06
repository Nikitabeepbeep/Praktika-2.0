﻿using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Color = System.Windows.Media.Color;
using NLog;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            InitializeComponent();
            {
                logger.Info("Запуск приложения");
            }
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
            logger.Info("Нажата кнопка о программе");
        }
        //очистить
        private void Button_Click4(object sender, RoutedEventArgs e)
            {
                if (stackPanelAdd.Children.Count > 0)
                {
                    stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count - 1);
                    logger.Info("Поле отображения очищено");
                }
            }
        //присоединение к базе данных
        private void Baza_dannyx(object sender, RoutedEventArgs e)
        {
            DBConnectionForm taskWindow = new DBConnectionForm();
            taskWindow.Owner = this;
            taskWindow.Show();
            logger.Info("Открыт модуль подключения к БД");
        }
        //чтение текста из файла
        private void newbutton1(object sender, RoutedEventArgs e)
        {
            logger.Info("Модуль чтения текста из файла запущен");
            StackPanel sp = new StackPanel();
            TextBox tb = new TextBox();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                tb.Text = File.ReadAllText(openFileDialog.FileName);
            logger.Info("Файл открыт успешно");
        }
        //открытие изображения
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("Попытка открыть файл");
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
                logger.Info("Файл открыт успешно");
            }
        }
        //mp3 плеер
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MP3_PLAYER taskWindow = new MP3_PLAYER();
            taskWindow.Owner = this;
            taskWindow.Show();
            logger.Info("Открыт модуль MP3_PLAYER");
        }
        //выход из приложения
        private void exit_CLick(object sender, RoutedEventArgs e)
        {
            logger.Info("Запуск модуля выхода из приложения");
            Environment.Exit(0);
            logger.Info("Приложение закрыто");
        }
        //сайт
        private void Application_NavigationFailed(object sender,
      RoutedEventArgs e)
        {
            logger.Info("Попытка открыть ссылку на гитхаб");
            try
            {
                Process.Start("explorer.exe", "https://github.com/Nikitabeepbeep/Praktika-2.0");
                logger.Info("Ссылка открыта успешно");
            }
            catch
            {
                logger.Error("Попытка открыть ссылку на гитхаб провалена!");
            }
        }
        //настройка цвета главного окна
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
            logger.Info("Цвет фона поменяли!");
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cmb_NumbersOrders_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 320;
            Application.Current.MainWindow.Height = 240;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 640;
            Application.Current.MainWindow.Height = 480;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 800;
            Application.Current.MainWindow.Height = 600;
            logger.Info("Размер главного окна изменён!");

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1024;
            Application.Current.MainWindow.Height = 768;
            logger.Info("Размер главного окна изменён!");

        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1152;
            Application.Current.MainWindow.Height = 864;
            logger.Info("Размер главного окна изменён!");

        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 600;
            logger.Info("Размер главного окна изменён!");

        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 720;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 800;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 960;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1280;
            Application.Current.MainWindow.Height = 1024;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1360;
            Application.Current.MainWindow.Height = 768;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1366;
            Application.Current.MainWindow.Height = 768;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_11(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1400;
            Application.Current.MainWindow.Height = 1050;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_12(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1440;
            Application.Current.MainWindow.Height = 900;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_13(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1600;
            Application.Current.MainWindow.Height = 900;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_14(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1680;
            Application.Current.MainWindow.Height = 1050;
            logger.Info("Размер главного окна изменён!");
        }

        private void ComboBoxItem_Selected_15(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 1920;
            Application.Current.MainWindow.Height = 1080;
            logger.Info("Размер главного окна изменён!");
        }
    }
}


