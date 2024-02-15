namespace Musify.API.Services.Logger
{
    public interface ILoggingService
    {
        /// <summary>
        /// Log specified information
        /// </summary>
        /// <param name="information">information to be logged</param>
        public void Log(string information);
    }
}