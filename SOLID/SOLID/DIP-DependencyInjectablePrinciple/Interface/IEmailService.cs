namespace AplicandoSOLIDNaPratica.DIP_DependencyInjectablePrinciple.Interface
{
    public interface IEmailService
    {
        void SendEmail(string to, string from, string subject, string message);
    }
}