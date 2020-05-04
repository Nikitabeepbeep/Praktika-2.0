using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;
namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для MP3_PLAYER.xaml
    /// </summary>
    public partial class MP3_PLAYER : Window
    {
        public MP3_PLAYER()
        {
            InitializeComponent();
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;
        //медиаплеер
        private void Button_ClickOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            bool? dialogOk = fileDialog.ShowDialog();
            if (dialogOk == true)
            {
                filename = fileDialog.FileName;
                FileName.Text = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
        }
        //воспроизвести
        private void Button_ClickPlay(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
        //пауза
        private void Button_ClicPause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
        //остановить
        private void Button_ClickStop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
        //закрыть+остановить
        private void DA(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
