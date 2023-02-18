// 9 Напишите программу, которая выводит случайное чмсло из отрезка - 10, 99
/*
Console.Clear();

int num = new Random().Next(10, 100); // num = 25
int a1 = num / 10; // a1 = 25 / 10 = 2
int a2 = num % 10; // a2 = 25 % 10 = 5
int max = a1;
if (max < a2)
    max = a2;
Console.WriteLine($"Максимальная цифра числа {num} -> {max}");      //Код работает!
*/



// 11 НП, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
int num = new Random().Next(100, 1000);
int a = num / 10 % 10 ; //861/10=86%10=8
Console.WriteLine($"Вторая цифра числа: {num} -> {a}");             //Код работает!
*/

//11 Напишите программу, которое выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//           918 = 9 * 100 + 1 * 10 + 8 
/*
Console.Clear();
int num = new Random().Next(100, 1000);
//Console.WriteLine($"{num} -> {result}"); другой вариант решения.
int result = (num / 100) * 10 + num % 10;
int a1 = num / 100;
int a2 = num / 10;
int a3 = num % 10;

Console.WriteLine($"{num} -> {a1}{a3}");
*/


// 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
Console.WriteLine ("Введите первое число: ");
double num = double.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine()!);
double ostatok = num % num2;
if (num % num2 == 0)
{
    Console.WriteLine($"{num}, {num2} -> Кратно");
}
    else
{
    Console.WriteLine($"{num}, {num2} -> Не кратно, Остаток {ostatok}"); // Код работает !
}
*/

/* 13 НП, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78-> третьей цифры нет 
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int index
*/

// 14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
/*
Console.Write("Введите число: ");
int num = int.Parse((Console.ReadLine())!);
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}                                               //  Код работает !
*/


/* 15 НП, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным ? 

6 - да
1- нет
5 -нет*/

/*
Console.Clear();
Console.WriteLine("Введите число от 1 до 7:");
Console.ReadLine();
int num = new Random().Next(1, 7);

    if (num == 1) //Не могу записать числа на проверку по порядку - типа 1,2,3,4,5 ?
    {
        Console.WriteLine($"{num}->Go to WORK");
    }
    else
    {
    Console.WriteLine($"{num}  -> ВЫХОДНОЙ");}
*/




// 16 НП, которая принимает на вход два числа и проверяет, является ли одно число квадратом второго.

/*
Console.Clear();
Console.WriteLine("Введите первое число  ");
double num = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число  ");
double num2 = double.Parse(Console.ReadLine()!);

if (num * num == num2 || num2 * num2 == num)
{
    Console.WriteLine($"Числа {num} b {num2} выполняют условия");
}
else
{
    Console.WriteLine($"Числа {num} and {num2} провалили задания");   // Код работает !
}
*/







