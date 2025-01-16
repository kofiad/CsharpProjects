// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue1 = " a ";
// string myValue2 = "A";
// Console.WriteLine( myValue1.Trim().ToLower() == myValue2.Trim().ToLower());

// int shoppingBill = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Shopping bill: {shoppingBill}, Discount: {(shoppingBill > 1000? 100 : 50)}");

// Random random = new();
// int flipOptions = random.Next(1, 3);
// string flip = flipOptions == 1 ? "Heads" : "Tails";
// Console.WriteLine(flip);

// string permission = "fish";
// int level = 40;
// string adminMessage = permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin User." : "Welcome, Admin user.";
// string managerMessage = permission.Contains("Manager") && level > 20 ? "Contact Admin for access." : "You do not have sufficient privilleges.";
// while (!permission.Contains("Admin") || !permission.Contains("Manager"))
// {
//     Console.WriteLine("You do not have sufficient privilleges.");
//     break;
// }
// Console.WriteLine( permission.Contains("Admin") ? adminMessage : managerMessage );

// bool flag = true;
// int value = 10;

// if (flag)
//     Console.WriteLine($"Inside the code block: {value}");

// int[] numbers = {4, 8, 15, 16, 23, 42};
// int total = 0;
// bool found = false;

// foreach ( int number in numbers )
// {
//     total += number;

//     if (number == 42)
//         found = true;
// }

// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     //removing a switch section will cause a merge with the subsequent case block
//     //modifying the switch section to include multiple labels
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = " Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName} is a {title}");

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// // if (product[0] == "01")
// //     type = "Sweat shirt";
// // else if (product[0] == "02")
// //     type = "T-Shirt";
// // else if (product[0] == "03")
// //     type = "Sweat pants";
// // else
// //     type = "Other";
// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// // if (product[1] == "BL")
// //     color = "Black";
// // else if (product[1] == "MN")
// //     color = "Maroon";
// // else
// //     color = "White";
// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "white";
//         break;
// }

// // if (product[2] == "S")
// //     size = "Small";
// // else if (product[2] == "M")
// //     size = "Medium";
// // else if (product[2] == "L")
// //     size = "Large";
// // else
// //     size = "One size fits all";
// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One size fits all";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = names.Length; i >= 1; i--)
// {
//     // Console.WriteLine(names[i - 1]);
//     if (names[i - 1] == "David")
//         names[i - 1] = "Sammy";
// }
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine(i);
// }

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     if (current >= 8)
//         continue;
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Random random = new Random();
// int monsterHealth = 10;
// int heroHealth = 10;

// while (monsterHealth > 0 && heroHealth > 0)
// {
//     int attack = random.Next(1, 11);
//     monsterHealth -= attack;
//     Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health");
//     if (monsterHealth <= 0)
//     {
//         Console.WriteLine("Hero Wins!");
//         break;
//     }

//     attack = random.Next(1, 11);
//     heroHealth -= attack;
//     Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health");
//     if (heroHealth <= 0)
//     {
//         Console.WriteLine("Monster Wins!");
//         break;
//     }
// }

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters: ");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
            Console.WriteLine($"You entered: {readResult}");
        }
        else
        {
            Console.WriteLine("Invalid entry. Please try again.");
        }
    }
} while (validEntry == false);
