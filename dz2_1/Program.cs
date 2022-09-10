void PrintSecondNumbers()
{
    Console.WriteLine("Введите трехзначное число ");
    int x = Convert.ToInt32(Console.ReadLine());
    int x1 = x / 10;
    int x2 = x1 % 10;
    Console.WriteLine(x2);
}
PrintSecondNumbers();