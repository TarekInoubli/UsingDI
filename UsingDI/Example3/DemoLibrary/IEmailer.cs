namespace DemoLibrary
{
    public interface IEmailer
    {
        void SendEmail(IPerson person, string message);
    }
}