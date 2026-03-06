using System;

// 1.
{
    Priority priority = Priority.High;
    if (priority == Priority.High) Console.WriteLine("높은 우선순위");
}
Console.WriteLine();

// 2.
{
    Animal animal = Animal.Tiger;
    if (animal == Animal.Tiger) Console.WriteLine("호랑이");
}
Console.WriteLine();

// 3.
{
    Console.WriteLine($"Red: {(int)Color.Red}, Green: {(int)Color.Green}, Blue: {(int)Color.Blue}");
}
Console.WriteLine();

// 4.
{
    Console.WriteLine(sizeof(SmallEnum));
}
Console.WriteLine();

// 5.
{
    Type consoleColor = typeof(ConsoleColor);
    string[] consoleColors = Enum.GetNames(consoleColor);
    
    foreach (string color in consoleColors) Console.WriteLine(color);
}
Console.WriteLine();

// 6.
{
    ConsoleColor consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "Red"); 
    Console.ForegroundColor = consoleColor;
    Console.WriteLine("빨간 텍스트");
    Console.ResetColor();
    Console.WriteLine("일반 텍스트");
}
Console.WriteLine();

// 7.
{
    string s1 = "Up";
    string s2 = "Forward";

    if (Enum.TryParse(s1, out Direction result))
    {
        Console.WriteLine($"변환 성공: {result}");
    }
    else
    {
        Console.WriteLine($"'{s1}'(은)는 유효하지 않음.");
    }

    if (Enum.TryParse(s2, out Direction result2))
    {
        Console.WriteLine($"변환 성공: {result2}");
    }
    else
    {
        Console.WriteLine($"'{s2}'(은)는 유효하지 않음.");
    }
}
Console.WriteLine();

// 8.
{
    Console.WriteLine($"1은 유효한 Animal 값인가?: {Enum.IsDefined(typeof(Animal), 1)}");
    Console.WriteLine($"100은 유효한 Animal 값인가?: {Enum.IsDefined(typeof(Animal), 100)}");
    Console.WriteLine($"'Tiger'은 유효한 Animal 값인가?: {Enum.IsDefined(typeof(Animal), "Tiger")}");
}
Console.WriteLine();

// 9.
{
    Console.WriteLine($"Right = {(int)Direction.Right}");
    Console.WriteLine($"2 = {(Direction)2}");
}
Console.WriteLine();

// 10.
{
    Console.WriteLine((Animal)100);
}
Console.WriteLine();


enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

enum SmallEnum : byte
{
    Left,
    Right,
    Top,
    Bottom
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}