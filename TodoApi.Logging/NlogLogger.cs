using NLog;
using TodoApi.Logging.Interface;

namespace TodoApi.Logging
{
    internal sealed class NlogLogger : TodoApi.Logging.Interface.ILogger
    {
        private Logger logger;

        internal NlogLogger(string loggerName)
        {
            logger = LogManager.GetLogger(loggerName);
        }

        public void Log(string message, TodoApi.Logging.LogLevel level)
        {
            NLog.LogLevel nlogLevel = GetNLogLevel(level);
            this.logger.Log(nlogLevel, message);
        }

        private NLog.LogLevel GetNLogLevel(TodoApi.Logging.LogLevel level)
        {
            NLog.LogLevel result = NLog.LogLevel.Off;
            switch(level)
            {
                case TodoApi.Logging.LogLevel.Info:
                    result = NLog.LogLevel.Info;
                    break;
                case TodoApi.Logging.LogLevel.Warning:
                    result = NLog.LogLevel.Warn;
                    break;
                case TodoApi.Logging.LogLevel.Error:
                    result = NLog.LogLevel.Error;
                    break;
                case TodoApi.Logging.LogLevel.Debug:
                    result = NLog.LogLevel.Debug;
                    break;
            }
            return result;
        }
    }
}