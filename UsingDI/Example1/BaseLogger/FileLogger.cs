namespace BaseLogger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendText(message);
        }
    }
}
