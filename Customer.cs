using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal abstract class Customer : ICustomer
    {

        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public decimal DiscountAmount { get; protected set; }
        public string DiscountType { get; protected set; }

        protected int NumOfTransactions = 0;

        protected Customer(string first, string last, string type)
        {
            FirstName = first;
            LastName = last;
            DiscountAmount = 0;
            DiscountType = type;
        }

        public abstract void CalculateDiscountAmount();

        public void PrintName()
        {
            Console.WriteLine($"Customer Name: {FirstName} {LastName} - {DiscountType}");           
        }

        public void SetDiscountAmmount(decimal discount)
        {
            DiscountAmount = discount;
        }
    }
}
