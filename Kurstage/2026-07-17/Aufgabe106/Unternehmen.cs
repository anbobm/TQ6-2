public class Unternehmen
{
    // ...

    private IEmailService emailService;

    public Unternehmen(string name, IEmailService emailService)
    {
        // ...

        this.emailService = emailService;
    }

    public void AbteilungHinzufügen(string abteilung)
    {
        // ...
        
        emailService.SendEmail("chef@company.com", "Neue Abteilung", $"Eine neue Abteilung {abteilung} wurde hinzugefügt.");
    }

    // ...
}

public interface IEmailService
{
    void SendEmail(string recipient, string subject, string content);
}

public class EmailService : IEmailService
{
    public void SendEmail(string recipient, string subject, string content)
    {
        // SMTP-Client öffnet verbindung zum SMTP-Server und verschickt Email
    }
}