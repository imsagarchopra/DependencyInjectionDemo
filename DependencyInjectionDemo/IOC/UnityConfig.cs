using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DependencyInjectionDemo.BusinessLayer;
using DependencyInjectionDemo.DAL;

namespace DependencyInjectionDemo.IOC
{
    class UnityConfig
    {
        IUnityContainer objContainer = new UnityContainer();
        
        public UnityConfig()
        {
            objContainer.RegisterType<IDAL, SqlServerDAL>();
            objContainer.RegisterType<IDAL, OracleServerDAL>();
            objContainer.RegisterType<ICustomer , Customer>();
            
        }
        
        public IUnityContainer GetContainer()
        {
            return objContainer;
        }
    }
}
