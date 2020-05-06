using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;
using NLog;
namespace Vasilchugov_Aminov
{
    /// <summary>
    /// Логика взаимодействия для MP3_PLAYER.xaml
    /// </summary>
    public partial class MP3_PLAYER : Window
    { 
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MP3_PLAYER()
        {
        try
        {
          InitializeComponent();
         logger.Info("Запуск MP3_PLAYER успешен");
        }
        catch
        {
         logger.Error("Запуск MP3_PLAYER провален");
        }
    }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;
        //медиаплеер
        private void Button_ClickOpen(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.Info("Попытка открыть mp3 файл");
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
                    logger.Info("Открытие файла произошло успешно");
                }
            }
            catch
            {
                logger.Error("Запуск MP3_PLAYER провален");
            }
                }
        //воспроизвести
        private void Button_ClickPlay(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
            logger.Info("Композиция запущена");
        }
        //пауза
        private void Button_ClicPause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
            logger.Info("Композиция поставлена на паузу");
        }
        //остановить
        private void Button_ClickStop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            logger.Info("Композиция остановлена");
        }
        //закрыть+остановить
        private void DA(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
            logger.Info("Моудль MP3_PLAYER свёрнут");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            logger.Info("Моудль MP3_PLAYER закрыт");
        }
    }
}
