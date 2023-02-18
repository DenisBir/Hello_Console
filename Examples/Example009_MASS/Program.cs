
Console.WriteLine($"Введите первое число  ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите второе число  ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите третье число  ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if(max < num2)
{
    max = num2;
}
 if(max < num3)
 {
    max = num3;
}
Console.WriteLine($"Самое большое число {max}");
int Max(int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = Max(3,5,7);
/*
int a1 = 12;
int b1 = 3;
int c1 = 5;
int a2 = 8;
int b2 = 34;
int c2 = 56;
int a3 = 76;
int b3 = 16;
int c3 = 57;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

//int max = Max(max1, max2, max3);

Console.WriteLine(max);
*/