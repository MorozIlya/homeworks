void PrintThirdnum()
{
int a = 0;
Console.WriteLine("Ведите целое число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < -99) {a = -1*x;} else {a = x;}
if (a > 99) 
    { 
        while (a > 999) {a = a/10;}
        Console.WriteLine("Третья цифра в числе " + x + "  это " + a%10);
    }
else {Console.WriteLine("Введенное число не является трехзначным, третьей цифры нет");}

return;
}
PrintThirdnum();