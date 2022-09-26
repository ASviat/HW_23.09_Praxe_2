Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
int count = -3;
int copy=num;
int kostyl=num;
while ( copy>0)
{

copy=copy/10;
count++;
}

int magic=1;

while (count>0)
{

magic=magic*10;
count--;
}

num=num/magic%10;

if (kostyl<100) Console.WriteLine("Третьей цифры нет"); 
 else Console.WriteLine($"Число {num} является третьим");

// УРРРАААА. Больше нет сил адаптировать эту задачу.