namespace PersonFactory
{
    public class Person
    {
        public Person(string name)
        {
            var logger = new Logger.Logger();
            logger.Log($"{name} was created");
        }
    }
}
