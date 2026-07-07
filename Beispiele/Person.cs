public class Person
{
    public string Name { get; }

    private Person(string name)
    {
        Name = name;
    }

    public static Person Create(string name)
    {
        if (String.IsNullOrEmpty(name))
        {
            return null;
        }

        return new Person(name);
    }
}