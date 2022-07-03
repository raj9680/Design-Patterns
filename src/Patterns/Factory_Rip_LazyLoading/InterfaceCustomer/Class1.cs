using System;

namespace InterfaceCustomer
{
    public interface ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public string BillDate { get; set; }
        public string Address { get; set; }

        void Validate();
    }

    // design pattern - Strategy pattern
    /// strategy pattern is a behavioral pattern which helps to select algorithms on runtime.
    public interface IValidation<AnyType>
    {
        void Validate(AnyType obj);
    }
}
