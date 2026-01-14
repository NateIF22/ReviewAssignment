//Nathan

namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a new instance of the Customer class
            Customer nathan = new TrialCustomer("Nathan", "Franks");
            Customer samantha = new PremiumCustomer("Samantha", "Malt");
            Customer jim = new ProCustomer("Jim", "Renice");

            DoPurchases(nathan);

            DoPurchases(samantha);

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
