namespace Musify.API.Services.Logger
{
    public class LoggingService : ILoggingService
    {
        private string _path;
        public LoggingService(IConfiguration config)
        {
            this._path = config["LogFile"] ?? throw new FileNotFoundException("Could not find logfile");
        }

        /// <summary>
        /// Log specified information
        /// </summary>
        /// <param name="information">information to be logged</param>
        public void Log(string information)
        {
            try
            {
                using StreamWriter sw = File.AppendText(this._path);
                sw.WriteLine($"{DateTime.Now} - {information}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not write to log file");
            }

        }
    }
}
