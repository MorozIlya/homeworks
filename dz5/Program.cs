// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine(String.Join(" ", array));
// int evenNum = 0;
// foreach (int element in array)
// {
//     if (element % 2 == 0)
//         evenNum++;
// }
// Console.WriteLine($"Количестно четных чисел в данном массиве: {evenNum}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(-15, 31);
// }
// Console.WriteLine(String.Join(" ", array));
// int SumOddPos()
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }
// Console.WriteLine("Сумма элементов массива на нечетных позициях: " + SumOddPos());

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 101);
    Console.Write(array[i]);
    Console.Write(", ");
}
Console.WriteLine();
int maxValue = array.Max<int>();
int minValue = array.Min<int>();
Console.WriteLine("Максимальный элемент массива: " + maxValue);
Console.WriteLine("Минимальный элемент массива: " + minValue);
int DiffMaxMin = maxValue - minValue;
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + DiffMaxMin);