Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

if (num >0 && num<=5) Console.WriteLine("Нет, будний.");
if (num==6||num==7) Console.WriteLine("Да, выходной.");
if (num<1||num>7) Console.WriteLine ("В неделе 7 дней.");