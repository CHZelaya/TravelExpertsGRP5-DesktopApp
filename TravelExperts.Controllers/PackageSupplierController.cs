using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperts.Models.Models;

namespace TravelExperts.Controllers
{
    public class PackageSupplierController
    {
        public static List<PackageDetailDTO> getDetailsByPackageId(int packageId)
        {
            List<PackageDetailDTO> packageDetails = new List<PackageDetailDTO>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                packageDetails = db.PackagesProductsSuppliers
                    .Join(db.ProductsSuppliers,
                    pps => pps.ProductSupplierId,
                    ps => ps.ProductSupplierId,
                    (pps, ps) => new { pps, ps })
                    .Join(db.Products,
                    ppsps => ppsps.ps.ProductId,
                    p => p.ProductId,
                    (combined, p) => new
                    { combined.pps,combined.ps, p})
                    .Join(db.Suppliers,
                    combined => combined.ps.SupplierId,
                    s => s.SupplierId,
                    (combined,s) => new PackageDetailDTO
                    {
                        PackageId = combined.pps.PackageId,
                        PackageProductSupplierId = combined.pps.PackageProductSupplierId,
                        SupName = s.SupName,
                        ProName = combined.p.ProdName
                    })
                    .Where(details => details.PackageId == packageId)
                    .ToList();
            }
            return packageDetails;
        }

        public static List<ProductsSupplierDTO> GetProductsSuppliers()
        {
            List<ProductsSupplierDTO> productsSuppliers = new List<ProductsSupplierDTO>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                productsSuppliers = db.ProductsSuppliers.
                    Join(db.Products,
                    ps => ps.ProductId,
                    p => p.ProductId,
                    (ps,p) => new {ps,p }).
                    Join(db.Suppliers,
                    pps => pps.ps.SupplierId,
                    s => s.SupplierId,
                    (pps,s) => new ProductsSupplierDTO
                    {
                        ProductSupplierId = pps.ps.ProductSupplierId,
                        ProductId = pps.ps.ProductId,
                        SupplierId = pps.ps.SupplierId,
                        ProName = pps.p.ProdName,
                        SupName = s.SupName
                    }
                    ).ToList();
            }
            return productsSuppliers; 
        }

        public static bool addNewProductSupplier(PackagesProductsSupplier packagesProductsSupplier)
        {
            bool result = true;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    if (packagesProductsSupplier != null)
                    {
                        bool exists = db.PackagesProductsSuppliers.Any(pps => pps.PackageId == packagesProductsSupplier.PackageId && pps.ProductSupplierId == packagesProductsSupplier.ProductSupplierId);
                        if (!exists)
                        {
                            db.PackagesProductsSuppliers.Add(packagesProductsSupplier);
                            db.SaveChanges();
                        } else
                        {
                            throw new Exception("This ProductSupplier already exists.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw;
            }
            return result;
        }
        public static bool DeletePackageProductSupplier(int PackageProductSupplierId)
        {
            bool result = true;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    PackagesProductsSupplier detailToBeDeleted = db.PackagesProductsSuppliers.Find(PackageProductSupplierId);
                    if (detailToBeDeleted != null)
                    {
                        db.PackagesProductsSuppliers.Remove(detailToBeDeleted);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw;
            }
            return result;
        }
    }
}
