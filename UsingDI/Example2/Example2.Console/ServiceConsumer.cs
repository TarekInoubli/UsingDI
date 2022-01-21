using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Console
{
    public class ServiceConsumer
    {
        HelloService _helloService;

        public ServiceConsumer(HelloService helloService)
        {
            _helloService = helloService;
        }

        public void Print()
        {
            _helloService.Print();
        }
    }
}
