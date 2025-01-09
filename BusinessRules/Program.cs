using System.Diagnostics;

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

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

//this entire array can actually be written as string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First fraudulent order ID: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second fraudulent order ID: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third fraudulent order ID: {fraudulentOrderIDs[2]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
