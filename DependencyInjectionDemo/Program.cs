using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DependencyInjectionDemo.BusinessLayer;
using DependencyInjectionDemo.IOC;

namespace DependencyInjectionDemo
{
    class Program
    {
        private ICustomer _custobj;
        
        public Program()
        {
            UnityConfig obj = new UnityConfig();
            IUnityContainer container =  obj.GetContainer();
            _custobj = container.Resolve<Customer>();
        }
        static void Main(string[] args)
        {
            //Customer obj = new Customer();
            Program program = new Program();
            program._custobj.CustomerName = "Test1";
            program._custobj.Add();
            
        }

    }
}
