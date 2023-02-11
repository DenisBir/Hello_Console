Console.WriteLine("Ведите два числа для сравнения");
Console.Write("Ведите число А - ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ведите число В - ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
if (numberA > numberB)
{
        Console.WriteLine("Max:"+numberA);
        Console.WriteLine("Min:"+numberB);
}
else if (numberA < numberB)
{
        Console.WriteLine("Max:"+numberB);
        Console.WriteLine("Min:"+numberA);
}
else
{
    Console.WriteLine("число" +numberA+" и " +numberB+ "равны");
}