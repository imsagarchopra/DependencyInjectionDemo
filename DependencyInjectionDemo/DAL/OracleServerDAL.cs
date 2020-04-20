using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DAL
{
    class OracleServerDAL : IDAL
    {
        public void Add()
        {
            Console.WriteLine("Added by Oracle Server");
            Console.Read();
        }
    }
}
