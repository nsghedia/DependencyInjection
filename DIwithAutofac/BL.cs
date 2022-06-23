namespace DIwithAutofac
{
    internal class BL : IBL
    {
        ILoggers _loggers;
        IDA _dA;

        public BL(ILoggers loggers,IDA dA)
        {
            _loggers = loggers;
            _dA = dA;
        }
        public void ProcessData()
        {
            _loggers.Log("Execution started...");
            _dA.SaveData("Dependency injection with autofac");
            _dA.LoadData();
        }
    }
}
