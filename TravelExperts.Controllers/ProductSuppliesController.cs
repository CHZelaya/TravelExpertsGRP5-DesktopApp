using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperts.Models.Models;

namespace TravelExperts.Controllers
{
    public class ProductSuppliesController
    {
        
        //crazy note!: static helps avoid making new object of class while caling
        // see reference
        public static List<Product> getAllProducts()
        {
            List <Product> result  = new List<Product>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                result = db.Products.ToList();
            }
            return result;
        }

        public static List<Supplier> getAllSuppliers()
        {
            List<Supplier> result = new List<Supplier>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                result = db.Suppliers.ToList();
            }
            return result;
        }

        public static List<Supplier> getSuppliersByProductId(int productId)
        {
            //select s.SupName,s.SupplierId
            //from Products p
            //join Products_Suppliers ps on p.ProductId = ps.ProductId
            //join Suppliers s on ps.SupplierId = s.SupplierId
            //order by p.ProductId,ps.SupplierId
            List<Supplier> result = new List<Supplier>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                //https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/join-operations
                result = (from p in db.Products
                          join ps in db.ProductsSuppliers on p.ProductId equals ps.ProductId
                          join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                          where ps.ProductId == productId
                         select new Supplier
                         {
                             SupName = s.SupName,
                             SupplierId = s.SupplierId
                         }).ToList();
            }
            if (!result.Any())
            {
                Console.WriteLine("No suppliers found for the given Product ID.");
                throw new Exception("No Supplier found");
            }
            return result;
        }
    }
}
