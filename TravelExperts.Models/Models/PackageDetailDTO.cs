using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts.Models.Models
{
    public class PackageDetailDTO
    {
        public int PackageId { get; set; }
        public int PackageProductSupplierId { get; set; }
        public string SupName { get; set; }
        public string ProName { get; set; }
    }
}
