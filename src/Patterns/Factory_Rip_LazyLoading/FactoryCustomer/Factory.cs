using InterfaceCustomer;
using Microsoft.Practices.Unity;
using MiddleLayer;
using ValidationAlorithms;

namespace FactoryCustomer
{
    public static class Factory  // converting to unity container approach
    {
        /// private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        // Static dictionary collection has been replaced by unity container
        private static IUnityContainer custs = null;


        ///public static CustomerBase Create(string TypeCust)
        // Decoupled from MiddleLayer with InterfaceCustomer
        public static ICustomer Create(string TypeCust)
        {
            ///if (custs.Count == 0)
            if (custs == null)
            {
                ///custs.Add("Customer", new Customer());
                ///custs.Add("Lead", new Lead());

                custs = new UnityContainer();
                // To add type into collection
                //custs.RegisterType<CustomerBase, Customer>("Customer"); - 1
                //custs.RegisterType<CustomerBase, Lead>("Lead"); -1

                // Later we decoupled MiddleLayer with InterfaceCustomer
                // Injected decoupled validation class/project -2
                custs.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                custs.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
            }

            ///return custs[TypeCust];
            // To get type from collection
            //return custs.Resolve<CustomerBase>(TypeCust);

            // Later we decoupled MiddleLayer with InterfaceCustomer
            return custs.Resolve<ICustomer>(TypeCust);
        }
    }
}
