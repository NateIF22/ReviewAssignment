using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    //Because trial customer inherits Customer class, it must have the abstracts pushed down by the Customer class.
    internal class TrialCustomer : Customer // Extends the Customer class, which extends the ICustomer class, creating a chain
    {
        private int DiscountUpperLimit = 3;
        //constructor (the : extends something) passes the first name and last name to the customer constructor (base)
        public TrialCustomer(string first, string last, string type = "Trial") : base(first, last, type)
        {//The m for decimal?
            DiscountAmount = 0.1m;
        }

        public override void CalculateDiscountAmount()
        {
            //Increment transaction counter (start new transaction)
            NumOfTransactions++;

            //When the num of transactions is 
            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmmount(0);
            }
            Console.WriteLine("Doing a transaction!");
        }

        public void DoStuff() //Only exists in trial customer, it can not be accessed from the parent customer class.
        {
            Console.WriteLine("This does stuff");
        }
    }
}
