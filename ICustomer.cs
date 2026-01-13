using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal interface ICustomer
    {
        // Contract for what methods a coustomer to have, only define how the class should look.
        void SetDiscountAmmount(decimal discount); // Just end statement because it is in an interface
        void PrintName();
        void CalculateDiscountAmount();
    }
}
