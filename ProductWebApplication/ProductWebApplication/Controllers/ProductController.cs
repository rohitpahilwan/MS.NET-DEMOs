using Microsoft.AspNetCore.Mvc;
using ProductWebApplication.Models;
using ProductWebApplication.Repositories;

namespace ProductWebApplication.Controllers
{
    public class ProductController : Controller
    {
        IDBManager _manager;
        public ProductController(IDBManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Product"]=_manager.GetProducts();
            return View();  
        }
        [HttpGet]
        public IActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult delete(int id)
        {
            _manager.delete(id);
            return RedirectToAction("Details","Product");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _manager.insert(product);
            return RedirectToAction("Details", "Product");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using(var context=new ProductCollection())
            {
                var product = context.Product.Find(id);
            return View(product);
            }
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            using(var context=new ProductCollection())
            {
                var p=context.Product.Find(product.Id);
                p.Title= product.Title;
                p.Description= product.Description;
                p.UnitPrice= product.UnitPrice;
                p.img_url= product.img_url;
                p.quantity= product.quantity;
                context.SaveChanges();
            }
                return RedirectToAction("Details","Product");
            
        }
        public IActionResult Sort()
        {
            using(var context=new ProductCollection())
            {
                List<Product> p=context.Product.OrderBy(x=>x.quantity).ToList();
                ViewData["Product"] = p;
                return View(p);
            }
        }

    }
}
