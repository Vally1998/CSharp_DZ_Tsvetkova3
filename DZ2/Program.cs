// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Решение

void Main()
{
    int m = ReadInt("Введите число m: ");
    int n = ReadInt("Введите число n: ");
    int PrintResult = A(m, n);
    System.Console.WriteLine(A(m, n));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n) 
{
    if(m == 0)
    {
        return (n + 1);
    }
    else if(n == 0)
    {
        return A(m - 1, 1);
    }
    else 
    {
        return A(m - 1, A(m, n - 1));
    }
}

