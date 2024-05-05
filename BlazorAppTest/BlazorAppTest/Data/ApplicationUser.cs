using Microsoft.AspNetCore.Identity;
using BlazorAppTest.Data.models;
namespace BlazorAppTest.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        
        
        private List<Purchase> _purchases;
        private List<Accrual> _accruals;
        public List<Purchase> Purchases { get { return _purchases; } set { _purchases = value; } }
        public List<Accrual> Accruals { get { return _accruals; } set { _accruals = value; } }
        
        public float Purchase_Amount(DateTime begin, DateTime end)
        {
            float total= 0;
            foreach (var purchase in Purchases)
            {
                if(purchase.DateTime<end & purchase.DateTime > begin)
                {
                    total += purchase.Price;
                }
            }
            return total;
        }
        public float Accrual_Amount(DateTime begin, DateTime end)
        {
            float total = 0;
            foreach (var purchase in Accruals)
            {
                if (purchase.DateTime < end & purchase.DateTime > begin)
                {
                    total += purchase.Price;
                }
            }
            return total;
        }
        public float total(DateTime begin, DateTime end)
        {
            return Accrual_Amount(begin, end) - Purchase_Amount(begin, end);
        }
    }

}