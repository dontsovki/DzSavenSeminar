// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

void PrintArray(int[,] matr) // Создание матрицы
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void SuitableMumber(int m, int n, int [,] array)    //функция нахождения элемнта по индексу
{
    if (m < array.GetLength(0) && n < array.GetLength(1)) Console.WriteLine($"{array[m, n]} - искомое число" );

    else Console.WriteLine($"{m} и {n} -> такого элемента в массиве нет");
}

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

SuitableMumber(rows,colums, array);
