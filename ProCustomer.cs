using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal class ProCustomer : Customer
    {
        private int DiscountUpperLimit = 5;
        public ProCustomer(
            string first,
            string last,
            string type = "Pro"
        ) : base(
            first,
            last,
            type)
        {
            DiscountAmount = 0.25m;
        }

        public override void CalculateDiscountAmount()
        {
            //Increment transaction counter
            NumOfTransactions++;

            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0.10m);
            }
            Console.WriteLine("Doing a transaction.");
            Console.WriteLine("Sending a thank you note");
        }
    }
}
