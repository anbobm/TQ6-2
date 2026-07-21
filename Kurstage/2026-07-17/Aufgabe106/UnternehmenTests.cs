using Moq;

namespace Aufgabe106;

public class UnternehmenTests
{
    [Fact]
    public void AbteilungHinzufügen_SendsEmail()
    {
        var mockEmailService = new Mock<IEmailService>();
        var unternehmen = new Unternehmen("Testunternehmen", mockEmailService.Object);

        unternehmen.AbteilungHinzufügen("Testabteilung");

        mockEmailService.Verify(s => s.SendEmail(
                            "chef@company.com",
                            "Neue Abteilung",
                            "Eine neue Abteilung Testabteilung wurde hinzugefügt."),
                        Times.Once);
    }
}
