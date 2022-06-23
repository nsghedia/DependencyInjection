using DependencyInjection.InterfaceFactory;

namespace DependencyInjection.Factory
{
    public class CacheService : ICacheService
    {
        public void Add(string key, object value)
        {
            throw new NotImplementedException();
        }
        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
}
