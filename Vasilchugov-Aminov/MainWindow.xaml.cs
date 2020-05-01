using Microsoft.Win32;
using System;
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
            sb.AppendLine("Выполнили:");
            sb.AppendLine("Аминов В.Т");
            sb.AppendLine("Васильчугов Н.А");
            sb.AppendLine("Наша ссылка на GitHub:");
            sb.AppendLine("https://github.com/Nikitabeepbeep/Praktika-2.0");
            sb.AppendLine("Руководители:");
            sb.AppendLine("Лебедев В.Н");
            sb.AppendLine("Гурьянова С.В");
            sb.AppendLine("Кашина М.А");
            MessageBox.Show(sb.ToString());
        }
        //очистить
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            WrapPanel wrapPanel = new WrapPanel();
            MessageBox.Show("Поле отображения  очищено!");
        }
        //присоединение к базе данных
        private void Baza_dannyx(object sender, RoutedEventArgs e)
        {
            DBConnectionForm taskWindow = new DBConnectionForm();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
        //откртыие файла
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
    }
}

