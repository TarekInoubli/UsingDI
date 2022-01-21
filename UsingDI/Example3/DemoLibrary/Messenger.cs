using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Messenger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Send message from Messenger to Console: {message}");
        }
    }
}
