using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.BusinessLayer
{
    interface ICustomer
    {
        string CustomerName { get; set; }
        void Add();
    }
}
