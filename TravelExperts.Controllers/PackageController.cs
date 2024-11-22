using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperts.Models.Models;

namespace TravelExperts.Controllers
{
    public class PackageController
    {
        public static List<PackageDTO> GetPackages()
        {
            List<PackageDTO> packages = new List<PackageDTO>();
            using(TravelExpertsContext db = new TravelExpertsContext())
            {
                packages = db.Packages.Select(
                    p => new PackageDTO
                    {
                        PackageId = p.PackageId,
                        PkgName = p.PkgName,
                        PkgStartDate = p.PkgStartDate,
                        PkgEndDate = p.PkgEndDate,
                        PkgDesc = p.PkgDesc,
                        PkgBasePrice = p.PkgBasePrice,
                        PkgAgencyCommission = p.PkgAgencyCommission
                    }).ToList();
            }
            return packages;
        }

        public static List<PackageDTO> GetPackagesByQuery(string? pkgName,DateTime? startDate,DateTime? endDate,Decimal? basePrice)
        {
            List<PackageDTO> packages = new List<PackageDTO>();
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    var query = db.Packages.AsQueryable();
                    if (!string.IsNullOrEmpty(pkgName))
                    {
                        query = query.Where(p => p.PkgName.Contains(pkgName));
                    }
                    if (startDate.HasValue)
                    {
                        query = query.Where(p => p.PkgStartDate >= startDate.Value);
                    }
                    if (endDate.HasValue)
                    {
                        query = query.Where(p => p.PkgEndDate <= endDate.Value);
                    }
                    if (basePrice.HasValue)
                    {
                        query = query.Where(p => p.PkgBasePrice == basePrice.Value);
                    }

                    packages = query.Select(
                        p => new PackageDTO
                        {
                            PackageId = p.PackageId,
                            PkgName = p.PkgName,
                            PkgStartDate = p.PkgStartDate,
                            PkgEndDate = p.PkgEndDate,
                            PkgDesc = p.PkgDesc,
                            PkgBasePrice = p.PkgBasePrice,
                            PkgAgencyCommission = p.PkgAgencyCommission
                        }
                        ).ToList();
                }
                return packages;
            }
            catch (Exception ex) {
                throw;
            }
        }

        public static bool AddPackage(Package package)
        {
            bool result = true;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    if (package != null)
                    {
                        db.Packages.Add(package);
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
        public static bool ModifyPackage(int PackageId,Package package)
        {
            bool result = true;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    Package modifiedPackage = db.Packages.Find(PackageId);
                    if (modifiedPackage != null)
                    {
                        modifiedPackage.PkgName = package.PkgName;
                        modifiedPackage.PkgStartDate = package.PkgStartDate;
                        modifiedPackage.PkgEndDate = package.PkgEndDate;
                        modifiedPackage.PkgDesc = package.PkgDesc;
                        modifiedPackage.PkgBasePrice = package.PkgBasePrice;
                        modifiedPackage.PkgAgencyCommission = package.PkgAgencyCommission;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result = false;
                throw;
            }
            return result;
        }
        public static bool DeletePackage(int PackageId)
        {
            bool result = true;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    Package packageToBeDeleted = db.Packages.Find(PackageId);
                    if (packageToBeDeleted != null) { 
                        db.Packages.Remove(packageToBeDeleted);
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
