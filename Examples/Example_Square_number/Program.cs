Console.Write("Enter a number: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int square = value* value;
Console.Write("Square of number: ");
Console.Write(square);