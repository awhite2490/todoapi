namespace TodoApi.Logging.Interface
{
    public interface ILogger
    {
        void Log(string message, TodoApi.Logging.LogLevel level);
    }
}