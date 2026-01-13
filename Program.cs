//Nathan

namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a new instance of the Customer class
            Customer toast = new TrialCustomer("Nathan", "Franks");
            Customer seconds = new PremiumCustomer("Sam", "Galt");
            Customer jim = new ProCustomer("Jim", "Pam");

            DoPurchases(toast);

            DoPurchases(seconds);

            DoPurchases(jim);

        }

        static void DoPurchases(Customer customer)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Starting Purchases:");
                customer.PrintName();

                //print purchase result
                Console.WriteLine($"Customer's discount is: {customer.DiscountAmount}");

                //Do purchase for the customer
                customer.CalculateDiscountAmount();
            }
        }
    }
}
