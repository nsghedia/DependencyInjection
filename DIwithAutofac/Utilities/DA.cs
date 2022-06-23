namespace DIwithAutofac
{
    internal class DA : IDA
    {
        public static string? MyData { get; set; }
        public void LoadData()
        {
            Console.WriteLine(MyData ?? "No data found");
        }
        public void SaveData(string name)
        {
            MyData = name;
        }
    }
}
