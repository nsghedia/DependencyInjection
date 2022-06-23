using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIwithAutofac
{
    internal class Application : IApplication
    {
        IBL _bL;
        public Application(IBL bL)
        {
            _bL = bL;
        }
        public void Run()
        {
            _bL.ProcessData();
        }
    }
}
