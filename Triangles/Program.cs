//collecting user input
Console.WriteLine("Enter the number of rows: ");
int number = Convert.ToInt32(Console.ReadLine());

//printing a right angle triange using nested loops
for ( int i = 0; i < number; i++)
{
    for (int j = 0; j < number - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//printing left angle triangle using nested loops
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < i + 1 ; j++)
    {
        Console.Write("*");
    }
    for (int k = 0; k < number - i - 1; k++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

//printing both right and left angle triangle using nested loops
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number - i -1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i + 1; k++)
    {
        Console.Write("*");
    }
    Console.Write(" ");
    for (int l = 0; l < i + 1; l++)
    {
        Console.Write("*");
    }
    for (int m = 0; m < number - i - 1; m++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

