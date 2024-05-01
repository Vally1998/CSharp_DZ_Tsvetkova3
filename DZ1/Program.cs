// Задача 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Решение

void Main()
{
    int number1 = ReadInt("Введите число M: ");
    int number2 = ReadInt("Введите число N: ");
    PrintNumbers(number1, number2);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (M <= N)
    {
        System.Console.Write(M + " ");
        PrintNumbers(M + 1, N);
    } 
}
Main();

