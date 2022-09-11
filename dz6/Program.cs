// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Укажите, сколько чисел Вы хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void InputNum(int M)
{
    for(int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());    
    }
}

int NumOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
InputNum(M);
Console.WriteLine("Количество чисел больше 0: " + NumOfPositive(array));