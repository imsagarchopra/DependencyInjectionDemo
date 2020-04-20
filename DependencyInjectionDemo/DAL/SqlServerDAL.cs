using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DAL
{
    class SqlServerDAL : IDAL
    {
        public void Add()
        {
            Console.WriteLine("Added by Sql Server");
            Console.Read();
        }
    }
}
