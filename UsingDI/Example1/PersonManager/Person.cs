using BaseLogger;

namespace PersonManager
{
    public class Person
    {
        public Person(string name, ILogger logger)
        {
            logger.Log($"{name} was created");
        }
    }
}