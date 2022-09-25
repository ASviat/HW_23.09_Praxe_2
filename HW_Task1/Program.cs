Console.WriteLine("Введите трехзначное число: ");
int num=Convert.ToInt32(Console.ReadLine());

bool isIt000(int number)
{
    return number>99 && number <= 1000;
}

if (isIt000(num))
{
    num=num%100/10;
    Console.WriteLine($"Второе число: {num}.");
}
else Console.WriteLine("Трехзначное число, камрад.");
