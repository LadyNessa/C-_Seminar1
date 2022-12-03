Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int x = -numberN;

while (x <= numberN)
{
    Console.WriteLine(x);
    x = x + 1;
}