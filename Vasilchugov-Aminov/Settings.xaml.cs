using DocumentFormat.OpenXml.Spreadsheet;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using Color = System.Windows.Media.Color;
using Colors = System.Windows.Media.Colors;

namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void change_color_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Color selectedcolor = (Color)(change_color.SelectedItem as PropertyInfo).GetValue(1,null);
            Background = new SolidColorBrush(selectedcolor);
            MainWindow p = new MainWindow();
            p.Background = new SolidColorBrush(selectedcolor);
            p.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            change_color.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
