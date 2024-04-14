namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            log log = new log();
            LogDel LogTextToScreen, LogTextToFile;
            LogTextToFile = new LogDel(log.LogTextToFile);
            LogTextToScreen = new LogDel(log.LogTextToScreen);

            LogDel multiLogDel = LogTextToFile + LogTextToScreen;
            Console.WriteLine("Enter any text");
            var name = Console.ReadLine();
            LogText(multiLogDel, name);
        }


        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }


    }
    
    class log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
            }
        }
    }
}