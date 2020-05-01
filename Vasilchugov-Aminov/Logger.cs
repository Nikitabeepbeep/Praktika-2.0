using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vasilchugov_Aminov
{

    public interface ILogger
    {
        TException СоздатьИсключение<TException>(string сообщение)
            where TException : Exception, new();

        void ЗаписатьВЛог(LogType типСообщения, string сообщение);

    }

    public enum LogType
    {
        Info,
        Warning,
        Error
    }

    public class Logger : ILogger
    {
        public Logger()
        {
            Инициализировать();
        }

        private void Инициализировать()
        {
            ЗаписатьСообщениеВЛогТекущейДаты(LogType.Info, "Успешный запуск");
        }

        public void ЗаписатьВЛог(LogType типСообщения, string сообщение)
        {
            ЗаписатьСообщениеВЛогТекущейДаты(типСообщения, сообщение);
            
        }
        private void ЗаписатьСообщениеВЛогТекущейДаты(LogType Info, string сообщение)
        {
            File.AppendAllText(DateTime.Now.ToString("dd-MM-yyyy") + ".log", DateTime.Now + ": " + сообщение + Environment.NewLine);
        }
        public TException СоздатьИсключение<TException>(string сообщение) where TException : Exception, new()
        {
            ЗаписатьВЛог(LogType.Error, сообщение);
            TException exc = new TException();
            return exc;
        }
    }
}
