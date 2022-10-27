

Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i);
    }
}
else
{
    Console.WriteLine("Введите положительное число");
}