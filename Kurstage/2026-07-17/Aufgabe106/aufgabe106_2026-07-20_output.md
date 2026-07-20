## Aufgabe 106 - Testergebnisse

Gegeben ist eine Klasse `Unternehmen`, die beim Hinzufügen einer Abteilung eine E-Mail über ein `IEmailService` verschickt.

Die konkrete Implementierung des E-Mail-Services soll im Unit-Test nicht verwendet werden. Stattdessen wird mit `Moq` ein Mock-Objekt erstellt.

```
public interface IEmailService
{
    void SendEmail(string recipient, string subject, string content);
}
```

### Ziel des Tests

Es soll geprüft werden, ob `AbteilungHinzufügen(...)` eine E-Mail mit den richtigen Daten verschickt:

- Empfänger: `chef@company.com`
- Betreff: `Neue Abteilung`
- Inhalt: `Eine neue Abteilung IT wurde hinzugefügt.`

### Test

```
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
```

### Ergebnis

```
dotnet test Kurstage/2026-07-17/Aufgabe106/Aufgabe106.csproj
```

```
Testzusammenfassung: gesamt: 1; Fehler: 0; erfolgreich: 1; übersprungen: 0
Build erfolgreich.
```

### Fazit

Der Test prüft mit `Verify()`, ob die Methode `SendEmail(...)` genau einmal mit den erwarteten Parametern aufgerufen wurde.

Es wird keine echte E-Mail verschickt.