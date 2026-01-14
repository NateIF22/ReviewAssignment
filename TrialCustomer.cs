using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal class TrialCustomer : Customer
    {
        private int DiscountUpperLimit = 3;
        public TrialCustomer(
            string first,
            string last,
            string type = "Trial"
        ) : base(
            first,
            last,
            type)
        {
            DiscountAmount = 0.1m;
        }

        public override void CalculateDiscountAmount()
        {
            //Increment transaction counter
            NumOfTransactions++;
            
            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0);
            }
            Console.WriteLine("Doing a transaction.");
        }
    }
}
