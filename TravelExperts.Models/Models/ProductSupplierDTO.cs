using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts.Models.Models
{
    public class ProductsSupplierDTO
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public string ProName { get; set; }
        public int? SupplierId { get; set; }
        public string SupName { get; set; }
        public string DisplayInfo => $"Prod:{ProName} , Supplier:{SupName}";
    }
}
