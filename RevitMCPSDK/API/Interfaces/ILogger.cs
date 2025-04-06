namespace RevitMCPSDK.API.Interfaces
{
    /// <summary>
    /// Log level
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }
    /// <summary>
    /// Logger interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message
        /// </summary>
        void Log(LogLevel level, string message, params object[] args);

        /// <summary>
        /// Logs a debug message
        /// </summary>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Logs an informational message
        /// </summary>
        void Info(string message, params object[] args);

        /// <summary>
        /// Logs a warning message
        /// </summary>
        void Warning(string message, params object[] args);

        /// <summary>
        /// Logs an error message
        /// </summary>
        void Error(string message, params object[] args);
    }
}
