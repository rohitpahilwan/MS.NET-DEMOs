using ProductWebApplication.Models;

namespace ProductWebApplication.Repositories
{
    public interface IDBManager
    {
        List<Product> GetProducts();

        void delete(int id);

        void insert(Product product);
    }
}
