namespace Aufgabe106;

public interface IEmailService
{
    void SendEmail(string recipient, string subject, string content);
}