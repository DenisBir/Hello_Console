Console.WriteLine("Ведите числа для сравнения");
Console.Write("Ведите число А - ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ведите число В - ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ведите число C - ");
int numberC = int.Parse(Console.ReadLine() ?? "0");

int max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write("max = ");

Console.WriteLine(max);