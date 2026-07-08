public class Isbn
{
    public string Value { get; }

    private Isbn(string value)
    {
        Value = value;
    }

    public static Isbn Create(string value)
    {
        if(IsValid(value))
        {
            return null;
        }

        return new Isbn(value);
    }

    public static bool IsValid(string isbn)
    {
        // (x1 + 3x2 + x3 + 3x4 + x5 + 3x6 + x7 + 3x8 + x9 + 3x10 + x11 + 3x12 + x13) ≡ 0 (mod 10).

        var count = 0;
        var sum = 0;
        for (int i = 0; i < isbn.Length; i++)
        {
            if (Char.IsDigit(isbn[i]))
            {
                var digit = Convert.ToInt32(isbn[i].ToString());
                
                if (count % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum += 3 * digit;
                }

                // // Alternative
                // sum += i % 2 == 0 ? digit : 3 * digit;

                count++;
            }
        }

        if (count != 13)
        {
            return false;
        }

        return sum % 10 == 0;
    }
}