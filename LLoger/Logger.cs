using LLoger.Interface;
using System.Reflection;

namespace LLoger
{
    public class Logger : ILLoger
    {
        private readonly log4net.ILog _logger;
        public Logger()
        {
            this._logger = log4net.LogManager.GetLogger(
                MethodBase.GetCurrentMethod().DeclaringType
            );
        }


        public void LogInformation(dynamic log)
        {
            this._logger.Info(log);
        }

        public void LogError(dynamic log)
        {
            this._logger.Error(log);
        }

        public void LogWarning(dynamic log)
        {
            this._logger.Warn(log);
        }
    }
}
