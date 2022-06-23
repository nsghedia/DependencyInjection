using DependencyInjection.Model;

namespace DependencyInjection.InterfaceFactory
{
    public interface IProduct
    {
        IEnumerable<Product> Products { get; }
        Product this[string name] { get; }
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
