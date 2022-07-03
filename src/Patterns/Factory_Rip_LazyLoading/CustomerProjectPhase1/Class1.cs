using InterfaceCustomer;
using System;

namespace MiddleLayer // Or Business Layer where busines logic will reside
{
    public class CustomerBase: ICustomer
    {
        // Create object of IValidation -> also we even decoupled the validation starategy
        private IValidation<ICustomer> validation = null;
        public CustomerBase(IValidation<ICustomer> obj)
        {
            validation = obj;
        }


        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public string BillDate { get; set; }
        public string Address { get; set; }
        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = "";
            Address = "";
        }

        // Virtual method
        public virtual void Validate()
        {
            /// throw new Exception("Not implemented");
            validation.Validate(this);     /// here 'this' refers to current object
        }
    }


    // Customer Class
    public class Customer : CustomerBase
    {
        // Moved below section to ValidationAlgorithm project to separate it from MiddleLayer
        /*
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
        */
        public Customer(IValidation<ICustomer> obj): base(obj)
        {
            
        }

    }

    // lead Class
    public class Lead : CustomerBase
    {
        // Moved below method section to ValidationAlgorithm project to separate it from MiddleLayer
        /*
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
        */
        public Lead(IValidation<ICustomer> obj): base(obj)
        {

        }
    }
}
