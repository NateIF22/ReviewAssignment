using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    // The ': ICustomer' is what the class inherits from, what it is based upon.
    internal abstract class Customer : ICustomer //(When the )ctrl period to auto add (abstract calss: shoild not be created, is a building block for creating other classes)
    {
        //type prop then enter, it does the rest
        //Protected meand that it is only available to the class and its children. Only the things in the namespace. Future proof, safe.
        //only the class can set it, better of both worlds with only the set as private / protected
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public decimal DiscountAmount { get; protected set; }
        public string DiscountType { get; protected set; }

        protected int NumOfTransactions = 0;

        //Constructor. type ctor for constructor, easy
        //Needs to have first and last name to be created.
        protected Customer(string first, string last, string type)
        {
            FirstName = first;
            LastName = last;
            //Can override later
            DiscountAmount = 0;
            DiscountType = type;
        }

        //Impliment abstractly
        public abstract void CalculateDiscountAmount();


        //Implimented interface. accessable by all the program (public) and is a single point to edit.
        public void PrintName()
        {
            Console.WriteLine($"Customer Name: {FirstName} {LastName} - {DiscountType}");           
        }

        //make abstract
        //An abstract class pushes the class requirements down to any children
        public void SetDiscountAmmount(decimal discount)
        {
            DiscountAmount = discount;
        }
    }
}
