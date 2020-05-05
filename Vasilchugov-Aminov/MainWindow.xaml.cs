using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media; 
using System.Windows.Media.Imaging;
using Color = System.Windows.Media.Color;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
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
            if (stackPanelAdd.Children.Count>0)
            {
            stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count-1);
         }
            MessageBox.Show("Поле отображения очищено!");
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
            StackPanel sp = new StackPanel();
            TextBox tb = new TextBox();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                tb.Text = File.ReadAllText(openFileDialog.FileName);
        }
        //открытие изображения
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
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
        //настройка цвета главного окна
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
        }

    }
}


