using Microsoft.EntityFrameworkCore;
using ProductWebApplication.Models;

namespace ProductWebApplication.Repositories
{
    public class DBManager:IDBManager
    {
        public void insert(Product product)
        {
            using(var context=new ProductCollection())
            {
                context.Product.Add(product);   
                context.SaveChanges();
            }
        }

        void IDBManager.delete(int id)
        {
           using (var context=new ProductCollection())
            {
                Product p = context.Product.Find(id);
                context.Product.Remove(p);
                context.SaveChanges();
            }
        }

        List<Product> IDBManager.GetProducts()
        {
            using(var context=new ProductCollection())
            {
                //var prod=from p in context.Product select p;
                //return prod.ToList<Product>();
                return context.Product.ToList();
            }
        }
    }
   
}
