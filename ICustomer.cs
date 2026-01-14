using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewAssignment
{
    internal interface ICustomer
    {
        void SetDiscountAmount(decimal discount);
        void PrintName();
        void CalculateDiscountAmount();
    }
}
