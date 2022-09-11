// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Укажите, сколько чисел Вы хотите ввести: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[M];

// void InputNum(int M)
// {
//     for(int i = 0; i < M; i++)
//     {
//         Console.Write($"Введите {i+1} число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());    
//     }
// }

// int NumOfPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// InputNum(M);
// Console.WriteLine("Количество чисел больше 0: " + NumOfPositive(array));



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] marks = new double[2, 2];
double[] inters = new double[2];
void InputMarks()
{
    for (int i = 0; i < marks.GetLength(0); i++)
    {
        Console.Write($"Введите точки {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < marks.GetLength(1); j++)
        {
            if (j == 0) Console.Write("Введите точку k: ");
            else Console.Write("Введите точку b: ");
            marks[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
double[] Decision(double[,] marks)
{
    inters[0] = (marks[1, 1] - marks[0, 1]) / (marks[0, 0] - marks[1, 0]);
    inters[1] = inters[0] * marks[0, 0] + marks[0, 1];
    return inters;
}
void Conclusion(double[,] marks)
{
    if (marks[0, 0] == marks[1, 0] && marks[0, 1] == marks[1, 1])
    {
        Console.Write("Прямые совпадают");
    }
    else if (marks[0, 0] == marks[1, 0] && marks[0, 1] != marks[1, 1])
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        Decision(marks);
        Console.Write($"Точка пересечения прямых: ({inters[0]}, {inters[1]})");
    }
}
InputMarks();
Conclusion(marks);