namespace Aufgabe104;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return password.Length >= 8;
    }
}