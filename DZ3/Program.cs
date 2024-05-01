// Задача 3
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

// Решение
void Main()
{
    int[] Array = { 4, 3, 0, 75, 16, 29, 34, 5, 7, 10 };
    PrintArrayReverse(Array, Array.Length - 1);
}

void PrintArrayReverse(int[] newArray, int i)
{
    if (i >= 0) 
    {
        System.Console.Write(newArray[i] + " ");
        PrintArrayReverse(newArray, i - 1);
    }
}

Main();