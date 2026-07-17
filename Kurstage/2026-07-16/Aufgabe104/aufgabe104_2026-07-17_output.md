## Aufgabe 104 - Testergebnisse

Gegeben ist die Klasse `PasswordValidator` und drei Tests dafür. Sieh dir an, welche Tests fehlschlagen, und behebe das Problem.

```
public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return password.Length > 8;
    }
}
```

```
public class PasswordValidatorTests
{
    [Fact]
    public void PasswordWithEightCharacters_IsValid()
    {
        Assert.True(new PasswordValidator().IsValid("12345678"));
    }

    [Fact]
    public void PasswordShorterThanEightCharacters_IsInvalid()
    {
        Assert.False(new PasswordValidator().IsValid("1234567"));
    }

    [Fact]
    public void PasswordLongerThanEightCharacters_IsValid()
    {
        Assert.True(new PasswordValidator().IsValid("123456789"));
    }
}
```

### Erster Testlauf vor der Korrektur

Beim ersten Testlauf ist ein Test fehlgeschlagen.

Fehlgeschlagener Test:

```
PasswordWithEightCharacters_IsValid
```

Fehler:

```
Expected: True
Actual:   False
```

Grund:

Die Methode `IsValid` hatte zuerst diese Bedingung:

```
return password.Length > 8;
```

Dadurch wurde ein Passwort mit genau 8 Zeichen als ungültig bewertet.

### Korrektur

Die Bedingung wurde geändert zu:

```
return password.Length >= 8;
```

Damit sind Passwörter mit 8 oder mehr Zeichen gültig.

### Zweiter Testlauf nach der Korrektur

Nach der Korrektur wurden alle Tests erfolgreich ausgeführt.

```
Test Summary: total: 3; failed: 0; passed: 3; skipped: 0
Build succeeded
```

### Ergebnis

Aufgabe104 ist korrekt gelöst.