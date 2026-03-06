using System;

// 1.
{
    Console.WriteLine($"Animal.Dragon: {(int)Animal.Dragon}, {(Animal)1}");
}
Console.WriteLine();

// 2.
{
    Array values = Enum.GetValues(typeof(Priority));
    foreach (Priority value in values)
    {
        Console.WriteLine($"{value} = {(int)value}"); 
     }
}

enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}