using MiddleLayer;
using System;
using System.Collections.Generic;

namespace FactoryCustomer
{
    public static class Class1 // Simple Factory pattern :- centralization of object creation
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        
        public static CustomerBase Create(string TypeCust)
        {
            // Lazy load design pattern   opposite is Eager loading
            if(custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            // RIP poly pattern
            return custs[TypeCust];
        }
    }
}
