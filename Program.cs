/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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
    int d = a;
    int s = 1;
    if(s < b);
    {
        int compos = d * d;
        s++;
    }
        else 
    {
        int compos = d * d;
    }
    return compos;
}

int num = InputNum("Введите первое число A: ");
int num1 = InputNum("Введите второе число B: ");
int res = Degree(num, num1);
Console.WriteLine($"Число A в степени B равно: {compos}");



/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/