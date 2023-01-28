﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

void FillArrayMaterial(double[,] matr)  //8. Функция заполнение массива. Принимает значения массива int[,] matrix, колтчество строк и столбцов
{
 for (int i = 0; i < matr.GetLength(0); i++) //9. Цикл For для создания количество строк, через функционал matr.GetLength(0) который принимает переданое значение "3" в 1 действии
 {
 for (int j = 0; j < matr.GetLength(1); j++)  //10. Цикл For для создания количество столбцов, через функционал matr.GetLength(1) который принимает переданое значение "4" в 1 действии
 {
 matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;

 //значениям массива matr[i,j] присвоиваем случайные числа от 1 до 10
 Console.Write($"{matr[i, j]} ");  //6. выводим на экран массив из нулей
 }
Console.WriteLine();
 }
}
double[,] matrix = new double[3, 4]; //1. Присваиваем массиву matrix число столбцов и строк и инициализируем массив командой "new"
FillArrayMaterial(matrix);   //7. передаём количество строк и столбцов в функцию "void FillArray"
