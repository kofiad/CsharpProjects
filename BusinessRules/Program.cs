using System.Diagnostics;
// This is a single line comment

/* This on the other hand,
is how to properly write a multi-line comment
*/

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

string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
int fraudulentOrderIDs = 0;

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"This order ID starts with a 'B': {orderID}");
        fraudulentOrderIDs++;
    }
}
Console.WriteLine($"There are {fraudulentOrderIDs} potentially fraudulent orders to process.");


int[] inventory = { 200, 450, 700, 175, 250 };
int sum  = 0;
int bin = 0;

foreach (int item in inventory)
{
    bin++;
    sum += item;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum } items in inventory.");

/*
    The following code creates five random orderIDs to test the fraud detection process.
    OrderIDs consists of a letter from A to E and a three-digit number. Example: A123
*/
Random random1 = new();
string[] orderIDs1 = new string[5];

for (int i = 0; i < orderIDs1.Length; i++)
{
    int prefixValue = random1.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random1.Next(1, 1000).ToString("000");

    orderIDs1[i] = prefix + suffix;
}

foreach (var orderID in orderIDs1)
{
    Console.WriteLine(orderID);
}
