using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Logger
    {
        private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

        // Enum to define message types
        public enum LogType { Error, Message, Warning }

        public static void Log(string message, LogType type)
        {
            try
            {
                string formattedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message} | {type} | {Environment.MachineName}";

                // Append text to the log file at the base directory of the project
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(formattedMessage);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to log message: {ex.Message}");
            }
        }
    }
}
