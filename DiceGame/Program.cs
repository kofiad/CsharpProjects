//how to implement the System.Random and System.Console class in C#.
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Random newDice = new Random();
int newRoll1 = newDice.Next(1, 7);
int newRoll2 = newDice.Next(1, 7);
int newRoll3 = newDice.Next(1, 7);
int total = newRoll1 + newRoll2 + newRoll3;

Console.WriteLine($"Dice roll: {newRoll1} + {newRoll2} + {newRoll3} = {total}");

if (newRoll1 == newRoll2 || newRoll2 == newRoll3 || newRoll1 == newRoll3)
{
    if (newRoll1 == newRoll2 && newRoll2 == newRoll3)
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total +=2;
    }
    Console.WriteLine($"Your total including bonus is {total}");
}
if (total >= 16)
{
    Console.WriteLine("You get a new car!");
}
else if (total >= 16)
{
    Console.WriteLine("You get a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You get a new an all expense paid trip for two!");
}
else
{
    Console.WriteLine("You get a new kitten!");
}
