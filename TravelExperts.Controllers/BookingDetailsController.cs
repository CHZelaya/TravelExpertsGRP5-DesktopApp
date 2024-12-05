using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperts.Models.Models;

namespace TravelExperts.Controllers
{
    public class BookingDetailsController
    {

        /// <summary>
        /// checks if the supplier has any upcoming customer bookings
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns></returns>
        public static BookingDetail GetFirstUpcomingBooking(int supplierId)
        {
            DateTime today = DateTime.Today;

            using (var db = new TravelExpertsContext()) // Replace with your actual DbContext
            {
                // Step 1: Get the ProductSupplierId for the given SupplierId
                var productSupplierId = db.ProductsSuppliers
                                                 .Where(ps => ps.SupplierId == supplierId)
                                                 .Select(ps => ps.ProductSupplierId)
                                                 .FirstOrDefault();

                if (productSupplierId == 0) // No matching ProductSupplierId found
                {
                    return null;
                }

                // Step 2: Find the first upcoming booking based on TripEnd
                BookingDetail? bd = db.BookingDetails
                                                    .Where(bd => bd.ProductSupplierId == productSupplierId && bd.TripEnd > today)
                                                    .OrderBy(bd => bd.TripEnd)
                                                    .FirstOrDefault();

                return bd;
            }
        }

    }
}
