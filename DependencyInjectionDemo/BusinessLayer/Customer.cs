using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.DAL;
using Microsoft.Practices.Unity;
using DependencyInjectionDemo.IOC;

namespace DependencyInjectionDemo.BusinessLayer
{
    class Customer : ICustomer
    {
        public IDAL odal;
        IUnityContainer container;
        public Customer()
        {
            UnityConfig obj = new UnityConfig();
            container = obj.GetContainer();
            
        }
        public string CustomerName { get; set; }

        public void Add()
        {

        }
    }
}
