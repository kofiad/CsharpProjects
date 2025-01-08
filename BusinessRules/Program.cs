Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage;
if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires soon.  Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration}days!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires in 1 day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else
{
    Console.WriteLine("Your subscription has expired");
}