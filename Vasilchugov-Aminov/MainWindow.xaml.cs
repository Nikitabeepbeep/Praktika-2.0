using NLog;
using System.Text;
using System.Windows;
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
        }
        //присоедение к БД
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DBConnectionForm taskWindow = new DBConnectionForm();
            taskWindow.Owner = this;
            taskWindow.Show();
        }
        //файл
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTxtFile addTxtFile = new AddTxtFile();
            addTxtFile.Show();
                    
        }
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
            sb.AppendLine("Аминов В.Т(9ИСП-391к-17)");
            sb.AppendLine("Васильчугов Н.А(9ИСП-391к-17)");
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
    }
}

