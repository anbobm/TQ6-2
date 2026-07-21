# Aufgabe 106

Gegeben ist folgende Klasse:

```csharp
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
```

Die Methode `AbteilungHinzufügen(..)` fügt eine Abteilung hinzu und sendet dabei eine Informations-Email. Die konkrete Implementierung ist für die `Unternehmen`-Klasse unwichtig, denn sie stellt nur auf das Interface `IEmailService` ab:

```csharp
public interface IEmailService
{
    void SendEmail(string recipient, string subject, string content);
}
```

Konkret könnte das Interface vielleicht so implementiert sein:

```csharp
public class EmailService : IEmailService
{
    void SendEmail(string recipient, string subject, string content)
    {
        // SMTP-Client öffnet verbindung zum SMTP-Server und verschickt Email
    }
}
```

Ein Objekt dieser Klasse `EmailService` in einem Unit-Test zu verwenden, der die Methode `AbteilungHinzufügen(..)` testen soll, wäre unpraktisch. Zum Einen wollen wir nur das Verhalten der Methode `AbteilungHinzufügen(..)` testen und nicht der `EmailService`-Klasse, zum anderen wollen wir in einem Unit-Test keine Nebeneffekte haben.

Wir könnten nun selbst eine Klasse nur für diesen Test schreiben, die keine wirkliche Email schickt, sondern nur für unseren Test festhält, dass die `SendEmail`-Methode aufgerufen wurde (= ein **Mock**).

```csharp
public class TestEmailService : IEmailService
{
    void SendEmail(string recipient, string subject, string content)
    {
        // festhalten, ob und wie diese Methode aufgerufen wurde
    }
}
```

Um sich diese Arbeit zu sparen, kann man z.B. die `Mock`-Klasse aus dem `Moq`-Paket verwenden.

Schreibe einen Unit-Test, der testet ob `AbteilungHinzufügen(..)` beim Hinzufügen einer Abteilung eine Email mit dem Betreff `"Neue Abteilung"` und dem Inhalt `"Eine neue Abteilung {abteilung} wurde hinzugefügt."` an `"chef@company.com"` schickt.

Nutze dafür die `Verify()`-Methode der `Mock`-Klasse.