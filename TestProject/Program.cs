Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue1 = " a ";
string myValue2 = "A";
Console.WriteLine( myValue1.Trim().ToLower() == myValue2.Trim().ToLower());

int shoppingBill = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Shopping bill: {shoppingBill}, Discount: {(shoppingBill > 1000? 100 : 50)}");

Random random = new();
int flipOptions = random.Next(1, 3);
string flip = flipOptions == 1 ? "Heads" : "Tails";
Console.WriteLine(flip);

string permission = "Manager";
int level = 40;
string adminMessage = permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin User." : "Welcome, Admin user.";
string managerMessage = permission.Contains("Manager") && level > 20 ? "Contact Admin for access." : "You do not have sufficient privilleges.";
Console.WriteLine( permission.Contains("Admin") ? adminMessage : managerMessage );
