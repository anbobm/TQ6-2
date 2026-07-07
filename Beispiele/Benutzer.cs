public class Benutzer
{
    private string benutzername;
    private string passwort;

    public bool IstEingeloggt { get; private set; }

    public Benutzer(string benutzername, string passwort)
    {
        this.benutzername = benutzername;
        this.passwort = passwort;
    }

    public void Login(string passwort)
    {
        if (this.passwort == passwort)
        {
            IstEingeloggt = true;
        }
    }

    public void Logout()
    {
        IstEingeloggt = false;
    }

    public bool PasswortÄndern(string altesPw, string neuesPw)
    {
        if (altesPw != this.passwort || neuesPw.Length < 8)
        {
            return false;
        }

        this.passwort = neuesPw;
        return true;
    }
}