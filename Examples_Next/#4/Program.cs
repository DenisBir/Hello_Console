
// 24 НП, которая принимает на вход число А и выведит сумму чисел от 1 до А
/*
int GetSum(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
        sum += i;       // sum = sum + i
    return sum;
}
Console.Write("Введите число:   ");

int n = int.Parse(Console.ReadLine());

//int result = GetSum(n);

Console.WriteLine($"Сумма от 1 до {n}  равна {GetSum(n)}");  // Вместо result сразу GetSum
*/

// 25 НП, которая принимает число и выдаёт количество цифр в числе.
/*
Console.Write("Введите число:   ");

int s = int.Parse(Console.ReadLine());

Console.WriteLine($"{CountNumbers(s)}");

int CountNumbers(int n)
{
    int count = 0;
    if (n < 0)
    n = n * (-1);
    while (n > 0)
    {
        n /= 10; // n = n / 10
        count++;
    }
    return count;
}
*/
/*
Console.Write("Введите число:   ");

int num = int.Parse(Console.ReadLine());

Console.WriteLine($"ok = {GetMultiply(num)}");

int GetMultiply(int n)
{
    int result = 1;
    int i = 2;
    if (n < 0){
    i = n;
    n = -1;
    }
    for (; i <= n; i++) 
    {
        result *= i;
    }
    return result;
}
*/

// 30
//Console.Clear();
//Console.Write("Ведите число:  ");

/*
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(",", array)}]");
Console.Write($"[]");
for (int i = 0; i < num - 1; i++){
    Console.Write($"{array[num - 1]}");
}
int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2); //диапазон от до
    }
    return result;
}
*/
double firstValue, secondValue;
string action;
Console.Write("Ведите число1:    ");
firstValue = double.Parse(Console.ReadLine()!);

Console.Write("Ведите число2:    ");
secondValue = double.Parse(Console.ReadLine()!);

Console.Write("Ведите операцию:     '+' '-' '*' '/' ");
action = (Console.ReadLine()!);

switch (action)
{
    case "+":
        Console.WriteLine(firstValue + secondValue);
        break;
    case "-":
        Console.WriteLine(firstValue - secondValue);
        break;
    case "/":
        if (secondValue
     == 0)
        {                           //фигурные скопки при одном действии можно не ставить!
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(firstValue / secondValue);
        }
        //Console.WriteLine(firstValue / secondValue);
        break;
    case "*":
        Console.WriteLine(firstValue * secondValue);
        break;
        default:
            Console.WriteLine("Ошибка действия!");
            break;
}



