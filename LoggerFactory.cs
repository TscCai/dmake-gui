using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sunny.UI;

namespace dmake.GUI
{
    public class LoggerFactory
    {
        static LogFile logger;
        public static LogFile GetLogger(string filePath = null) {
            if (logger == null) {
                logger = new LogFile();
                if (!String.IsNullOrEmpty(filePath)) {
                    logger.FilePath = filePath;
                }
            }
#if DEBUG
            logger.Level = LogLevel.DEBUG;
#else
            logger.Level = LogLevel.ERROR;
#endif

            return logger;
        }
    }
}
