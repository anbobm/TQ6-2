namespace Aufgabe106;

public class Unternehmen
{
    private IEmailService emailService;

    public Unternehmen(string name, IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void AbteilungHinzufügen(string abteilung)
    {
        emailService.SendEmail(
            "chef@company.com",
            "Neue Abteilung",
            $"Eine neue Abteilung {abteilung} wurde hinzugefügt."
        );
    }
}