using BaseLogger;

namespace PersonManager
{
    public class PersonFactory
    {
        Person GetPerson()
        {
            var logger = new ConsoleLogger();

            return new Person("Gerald", logger);
        }
    }
}
