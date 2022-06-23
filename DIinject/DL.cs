using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIinject
{
    internal class DL : IProduct
    {
        public string Insertdata()
        {
            string str = "Dependency injected via unity";
            Console.WriteLine(str);
            return str;
        }
    }
}
