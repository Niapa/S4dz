/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Degree(int a, int b)
{
    int s = 1;
    if (s < b) ;
    {
        int compos = a * a;
        s++;
    }
        else
    {
        compos = a * a;
    }
    return compos;
}

int num = InputNum("Введите первое число A: ");
int num1 = InputNum("Введите второе число B: ");
int res = Degree(num, num1);
Console.WriteLine($"Число A в степени B равно: {compos}");
*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Count(int x)
{
    int sum = 0;
    for(x>0)
    {
        int y = x%10;
        int z = x/10;
        int sum = y+sum;
    }
    return sum;
}

int num = InputNum("Введите целое число: ");
int res = Count(num);
Console.WriteLine($"Число A в степени B равно: {res}");

*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] ArrayRand(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1)
        Console.Write(", ");
        else
        Console.Write("]");
    }
}
int size = 8;
ArrayRand(size);
Console.WriteLine("Массив из 8 элементов: ");
int[] arr = ArrayRand(size);
PrintArray(arr);