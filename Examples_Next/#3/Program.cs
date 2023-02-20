/*

Console.Clear();
Console.Write("Выведите Х:  ");
int X = int.Parse(Console.ReadLine());

Console.Write("Ввитите Y:  ");
int Y = int.Parse(Console.ReadLine());

      if (X > 0 && Y > 0){
    Console.WriteLine("1");
}else if (X < 0 && Y> 0){
    Console.WriteLine("2");
}else if (X > 0 && Y < 0){
    Console.WriteLine("3");
}else if (X > 0 && Y < 0){
    Console.WriteLine("4");
}else if (X == 0 || Y == 0)
    Console.WriteLine("На оси");
*/

// 18 НП, которая по заданному номеру четвети, показывает диапазон возможных координат точек в этой четверти (Х и У)
/*
Console.Clear();
Console.Write("Выведите номер четверти:  ");
int num = int.String(Console.ReadLine());

      if (num = 1){
    Console.WriteLine("X > 0  Y > 0");
}else if (num = 2){
    Console.WriteLine("X < 0  Y> 0");
}else if (num = 3){
    Console.WriteLine("X > 0  Y < 0");
}else if (num = 4){
    Console.WriteLine("X > 0  Y < 0");              // Код не работает !
}
*/
/*
Console.Clear();
Console.Write("Выведите номер четверти:  ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)                                //switch это типа что то вроде if , удобна для восприятия
{
    case 1:{
        Console.WriteLine("X > 0  Y > 0");
        break;    }
    case 2:{
        Console.WriteLine("X < 0  Y> 0");
        break;    }
    case 3:{
        Console.WriteLine("X > 0  Y < 0");
        break;    }
    case 4:{
        Console.WriteLine("X > 0  Y < 0");
        break;    }
    default:{
        Console.WriteLine("Введена отсутствующая четверть");        // Код работает !
        break;
    }
}
*/
/*
Console.Clear();
Console.Write("Выведите X1:  ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Выведите Y1:  ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Выведите X2:  ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Выведите Y2:  ");
double y2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));  // за координатами - 2 это СТЕПЕНЬ !!!

Console.WriteLine($"d={d:f2}");      // f2 два знала после затятой
*/

Console.Clear();
Console.Write("Выведите число N:  ");
int N = int.Parse(Console.ReadLine());          // начальные значения - условия - 
int i = 1;
int m = N;        //m = - 10
if (N < 0){         // если n  отрицательная то цикл идет от отрицательных -10 до 0
    i = N;   //i = -10
    m = -N;  // m = 10
    N = -1;  // N = -1
}
int [] result = new int[m];   // вводим массив
for (int j = 0; i <= N; i++)   // j переберае массив, 
{
    result [j] = i * i;         // в j кладем выражение i*i при при положительных числах
    j++;
}
for (int j = 0; j < m; j++)         // for  - перебирает весь массив
{
    Console.Write($"{result[j]}"); 
}



