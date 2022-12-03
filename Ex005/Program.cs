Console.WriteLine("Введите трехзначное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (100 < numberN)
{
    if (numberN < 1000)
    {
    double x = numberN % 10;
    Console.WriteLine(x);
    }
    else
    {
    Console.WriteLine("Ошибка, введите трехзначное число: ");
    }
}

