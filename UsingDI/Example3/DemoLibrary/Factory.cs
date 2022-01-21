using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static ILogger CreateLogger()
        {
            //return new Logger();
            return new Messenger();
        }

        public static IEmailer CreateEmailer()
        {
            return new Emailer();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateEmailer());
        }
    }
}
