using TodoApi.Logging.Interface;

namespace TodoApi.Logging
{
    public static class LoggerFactory
    {
        public static ILogger GetLogger(string loggerName)
        {
            return new NlogLogger(loggerName);
        }
    }
}