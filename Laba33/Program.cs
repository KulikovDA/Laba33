try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    double s = 1;
    for (int k = 1; k <= 1; k += 2)
    {
        for (int i = 1; i <= n; i++)
        {
            long f = 1;
            for (int j = 1; j <= 1; j++) f *= j;
            if (i % 2 == 0)
            {
                s += (k / (1 * f) * (Math.Pow((x / 2), i)));
            }
            Console.Write($"S={s:F2}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
