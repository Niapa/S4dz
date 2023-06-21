/*
Задача 25:
__________
 Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B.
 ______________________________________________________________________________________________
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Degree(int a, int b)
{
    int compos = 1;
    while (b > 1) 
    {
        compos = compos * a;
        b--;
    }
    compos = compos * a;
    return compos;
}

int num = InputNum("Введите целое число A: ");
int num1 = InputNum("Введите натуральное число B: ");
int res = Degree(num, num1);
Console.WriteLine($"Число A в степени B равно: {res}");



/*Задача 27:
____________
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
_______________________________________________________________________________________________


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Count(int x)
{
    int sum = 0;
    while (x>=1)
    {
        sum = x % 10 + sum;
        x = x / 10;            
    }
    return sum;
}

int num = InputNum("Введите целое число: ");
int res = Count(num);
Console.WriteLine($"Сумма цифр в числе равна: {res}");

Задача 29:
__________
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
________________________________________________________________________________________________

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
*/