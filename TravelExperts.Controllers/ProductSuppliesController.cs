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
        
        //note: static helps avoid making new object of class while caling
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

        /// <summary>
        /// gets product of the supplier by supplier id
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns></returns>
        public static Product getProductBySupplierId(int supplierId) {
            Product result = new Product();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                result = db.Products
                        .Join(db.ProductsSuppliers,
                              p => p.ProductId,
                              ps => ps.ProductId,
                              (p, ps) => new { Product = p, ProductSupplier = ps })
                        .Where(x => x.ProductSupplier.SupplierId == supplierId)
                        .Select(x => x.Product)
                        .FirstOrDefault();

            }
            return result;
        }

        public static int AddOrUpdateProdSupp(Supplier s, Product p)
        {
            int rowsAffected = 0;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                // Add or update supplier
                if (s.SupplierId > 0)
                {
                    db.Suppliers.Update(s); // Update existing supplier
                }
                else
                {
                    //generate auto increment supp id
                    int idMax = db.Suppliers.Max(s => s.SupplierId);
                    s.SupplierId = ++idMax;
                    db.Suppliers.Add(s); // Add new supplier
                }
                
                // Check if a ProductSupplier entry exists
                var productSupplier = db.ProductsSuppliers
                    .FirstOrDefault(ps => ps.SupplierId == s.SupplierId);

                if (productSupplier != null)
                {
                    // Update existing ProductsSupplier
                    productSupplier.ProductId = p.ProductId;
                    db.ProductsSuppliers.Update(productSupplier);
                }
                else
                {
                    // Add a new ProductsSupplier entry
                    var newProductSupplier = new ProductsSupplier
                    {
                        SupplierId = s.SupplierId,
                        ProductId = p.ProductId
                    };
                    db.ProductsSuppliers.Add(newProductSupplier);
                }

                // Save changes for both operations
                rowsAffected += db.SaveChanges();
            }

            return rowsAffected;
        }


        /// <summary>
        /// returns supplier from supplier id
        /// </summary>
        /// <param name="supId"></param>
        /// <returns></returns>
        public static Supplier getSupplierBySupplierId(int supId)
        {
            Supplier s = new Supplier();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                s = db.Suppliers
                    .Where(s => s.SupplierId == supId)
                    .Single();
            }
            return s;
        }

        /// <summary>
        /// deletes supplier using supplier id
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns> rows affected </returns>
        public static int deleteSupplierById(int supplierId)
        {
            int res = 0;
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    Supplier s = getSupplierBySupplierId(supplierId);
                    if (s != null)
                    {
                        db.Suppliers.Remove(s);
                        res = db.SaveChanges();
                    }
                }
            }
            return res;
        }
    }
}
