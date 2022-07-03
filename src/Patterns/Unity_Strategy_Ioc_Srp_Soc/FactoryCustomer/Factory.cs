using MiddleLayer;
using System;
using System.Collections.Generic;

namespace FactoryCustomer
{
    public static class Factory // Simple Factory pattern :- centralization of object creation
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();  // xx
        
        // Moved this section to Create method to create the objects only when needed
        
        ///  static Factory()
        ///  {
        ///      custs.Add("Customer", new Customer());
        ///      custs.Add("Lead", new Lead());
        ///  }

        public static CustomerBase Create(string TypeCust)
        {
            // Taken this section from WinFormCustomer project in order to achieve centralised object creation 1
            // After our approach to remove multiple if else statements & it has been achieved by the creating a dictionary and assigning object cration as a value in constructor xx 2 & returning that in method
            // But the problem in 2 is that object is getting created at runtime whether it is needed by application or not. To achieve this optimization we removed the ctor and moved that section inside create method based on requirement.3  XXX
            ///  if(comboBox1.Text == "Customer")    xyz
            ///  {
            ///      cust = new Customer();
            ///  }
            ///  else
            ///  {
            ///     // lead = new Lead();    
            ///      cust = new Lead();     1
            ///  }

            // Lazy load design pattern (load/create obj. when needed   opposite is Eager loading 3 - XXX
            if (custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            // RIP poly pattern -- Removing multiple if with polymorphism 2  xyz
            return custs[TypeCust];
        }
    }
}
