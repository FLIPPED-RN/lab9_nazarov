//Вычисление бесконечных сумм, вариант 9.
try
{
    Console.WriteLine("Введите x: ");
    double x = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите n: ");
    double n = double.Parse(Console.ReadLine());

    double sum = 1;
    for (int i = 1; i <= n; i++)
    {
        long f = 1;
        for (int j = 1; j <= 4 * i - 3; j++) f *= j;
        sum += Math.Pow(x, 4 * i - 3) / f;
        
    }
    Console.WriteLine($"S = {sum:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}