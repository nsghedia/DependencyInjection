namespace DependencyInjection.InterfaceFactory
{
    public interface ICacheService
    {
        void Add(string key, object value);
        T Get<T>(string key);
    }
}
