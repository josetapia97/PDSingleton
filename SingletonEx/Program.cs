
using SingletonEx;

EventLogger logger = EventLogger.GetInstance();
logger.LogEvent("Starting App");
logger.LogEvent("First Test");

EventLogger logger2 = EventLogger.GetInstance();

logger.LogEvent("Upps i forgive log something");
logger.LogEvent("Finish fix task 1");

EventLogger logger3 = EventLogger.GetInstance();

logger.LogEvent("Ending App");

logger.DisplayLogs();