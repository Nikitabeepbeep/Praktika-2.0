using System;
using System.Windows;
using Microsoft.Win32;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для AddTxtFile.xaml
    /// </summary>
    public partial class AddTxtFile : Window
    {
        public AddTxtFile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
    }
}



