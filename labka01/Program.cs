Task_1();
Task_2();
Task_3();

static void Task_1()
{
    Console.WriteLine("TASK 1");
    double n;
    do
    {
        Console.Write("введiть 0<n<1:");
        n = double.Parse(Console.ReadLine());
    } while (n <= 0 || n >= 1);

    double copyN = n;
    string result = "0.";
    for (int i = 0; i < 7; i++)
    {
        copyN *= 8;
        int intCopy = (int)copyN;
        result += intCopy;
        copyN -= intCopy;
    }
    Console.WriteLine($"число {n} у вiсiмковiй системi числення = {double.Parse(result)}");
}

static void Task_2()
{
    Console.Write("\nTASK_2\nвведiть x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("введiть y:");
    double y = double.Parse(Console.ReadLine());
    Console.Write("введiть z:");
    double z = double.Parse(Console.ReadLine());

    double xyz = x * y * z;
    double num = xyz - 3 * Math.Abs(x + Math.Cbrt(y));
    double denum = 10 * 10 * 10 + Math.Sqrt(Math.Log10(24));

    double a, b, c;
    a = num / denum;
    b = denum * Math.Sin(xyz) - Math.Pow(Math.Cos(xyz), 2);
    c = xyz - Math.Pow(xyz, 3) / 6;
    double result = Math.Min(Math.Max(a, b), c);

    Console.WriteLine($"a = {a}, b = {b}, c = {c} \nmin(max(a,b),c) = {result}");
}

static void Task_3()
{
    const int n = 7;
    const int m = 5;
    double[,] matrixA = new double[n, m];
    Console.WriteLine("\nTASK_3\nвведiть матрицю 7х5:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"A[{i},{j}] = ");
            matrixA[i, j] = double.Parse(Console.ReadLine());
        }
    }

    Console.WriteLine("\nматриця А:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{matrixA[i, j]}\t");
        }
        Console.WriteLine();
    }

    double[] b = new double[m];
    for (int j = 0; j < m; j++)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrixA[i, j] > 0)
            {
                sum += matrixA[i, j];
            }
        }
        b[j] = sum;
    }

    int minIndex = 0;
    for (int j = 1; j < m; j++)
    {
        if (b[j] < b[minIndex])
        {
            minIndex = j;
        }
    }

    Console.Write("\nвектор b(сума додатнiх елементiв стовпцiв матрицi А): ");
    for (int j = 0; j < m; j++)
    {
        Console.Write(b[j] + " ");
    }
    Console.WriteLine($"\niндекс мiнiмального елемента вектора b: {minIndex}");
}
