Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine("Третьей цифры нет");

if (num >=100 && num<1000)
{
    num=num%10;
    Console.WriteLine($"Число {num} является третьим");
}
if (num >=1000 && num<10000)
{
    num=num/10%10;
    Console.WriteLine($"Число {num} является третьим");
}
if (num >=10000 && num<100000)
{
    num=num/100%10;
    Console.WriteLine($"Число {num} является третьим");
}
