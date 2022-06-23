namespace DIinject
{
    internal class Loggers : ILoggers
    {
        public void Log(string msg)
        {
            Console.WriteLine($"--------Log information------ \n{msg}");
        }
    }
}
