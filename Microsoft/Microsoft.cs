Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription will expire in a few days. Renew now!");
    Console.WriteLine("Renew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration < 2)
{
    Console.WriteLine("Your subscription will expire tomorrow! Renew now!");
    Console.WriteLine("Renew now and save 20%!");
    discountPercentage = 20;
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}


