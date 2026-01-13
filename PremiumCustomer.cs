using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal class PremiumCustomer : Customer
    {
        public PremiumCustomer(
            string first,
            string last,
            string type = "Premium"
        ) : base(
            first,
            last,
            type
        )
        {
            DiscountAmount = 0.1m;
        }

        public override void CalculateDiscountAmount()
        {
            //Increment transaction counter (start new transaction)
            NumOfTransactions++;

            Console.WriteLine("Doing a transaction!");
        }
    }
}
