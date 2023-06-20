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
    int s = 1;
    if(s < b);
    {
        s = s * s;
        s++;
    }
        else if s = b;
    {
        s = s * s;
    }
    return s;
}

int num = InputNum("Введите первое число A: ");
int num1 = InputNum("Введите второе число B: ");
int res = Degree(num, num1);
Console.WriteLine($"Число A в степени B равно: {res}");