using System;

namespace MiddleLayer // Or Business Layer where busines logic will reside
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public string BillDate { get; set; }
        public string Address { get; set; }

        // Virtual method
        public virtual void Validate()
        {
            throw new Exception("Not implemented");
        }
    }


    // Customer Class
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (BillAmount == 0)
            {
                throw new Exception("Bill amount is required");
            }
            if (BillDate.Length == 0)
            {
                throw new Exception("Bill date not is required");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address required");
            }
        }

    }

    // lead Class
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
