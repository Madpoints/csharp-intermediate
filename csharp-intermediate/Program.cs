using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediate
{
    public class GoldCustomer : Customer
    {
        // Calculate rating no longer exists, this class is now broken
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }   
    }

    partial class Program
    { 
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
        }
    }
}
