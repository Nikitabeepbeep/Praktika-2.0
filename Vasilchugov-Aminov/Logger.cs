using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Vasilchugov_Aminov
{
    public interface ILogger
    {
        TException СоздатьИсключение<TException>(string сообщение)
            where TException: Exception, new();

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
            ЗаписатьСообщениеВЛогТекущейДаты(LogType.Info, "Запуск модуля ведения журнала");
        }

        public void ЗаписатьВЛог(LogType типСообщения, string сообщение)
        {
            ЗаписатьСообщениеВЛогТекущейДаты(типСообщения, сообщение);
        }

        private void ЗаписатьСообщениеВЛогТекущейДаты(LogType типСообщения, string сообщение)
        {
            //добавить в файл /logs/yyyy-mm-dd.log текст
            // $"{DateTime.Now.Time.ToString()} {текст}"
        }

        public TException СоздатьИсключение<TException>(string сообщение) where TException : Exception, new()
        {
            ЗаписатьВЛог(LogType.Error, сообщение);
            TException exc = new TException();
            //нужно добавить в exc текст сообщения
            return exc;
        }
    }
}
