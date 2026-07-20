using Moq;

namespace Aufgabe106;

public class UnternehmenTests
{
    [Fact]
    public void AbteilungHinzufügen_SendetEmailAnChef()
    {
        var mockEmailService = new Mock<IEmailService>();
        var unternehmen = new Unternehmen("Foo", mockEmailService.Object);

        unternehmen.AbteilungHinzufügen("IT");

        mockEmailService.Verify(emailService => emailService.SendEmail(
            "chef@company.com",
            "Neue Abteilung",
            "Eine neue Abteilung IT wurde hinzugefügt."
        ), Times.Once);
    }
}