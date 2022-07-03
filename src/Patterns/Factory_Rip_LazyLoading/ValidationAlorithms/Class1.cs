using InterfaceCustomer;
using System;

namespace ValidationAlorithms
{
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill amount is required");
            }
            if (obj.BillDate.Length == 0)
            {
                throw new Exception("Bill date not is required");
            }
            if (obj.Address.Length == 0)
            {
                throw new Exception("Address required");
            }
        }
    }

    public class LeadValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer name is required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }
}
