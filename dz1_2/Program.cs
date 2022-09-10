Console.WriteLine("Введите 3 числа");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double c = Convert.ToInt32(Console.ReadLine());
double max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine("Максимальное число "+max);