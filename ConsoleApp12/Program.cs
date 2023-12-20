using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите задание от 1 до 14 (или введите 'exit' для выхода):");
            string NomerZadania = Console.ReadLine();

            if (NomerZadania.ToLower() == "exit")
            {
                break;
            }

            int TNumber;
            if (!int.TryParse(NomerZadania, out TNumber) || TNumber < 1 || TNumber > 14)
            {
                Console.WriteLine("EROR");
                continue;
            }

            switch (TNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                case 10:
                    Task10();
                    break;
                case 11:
                    Task11();
                    break;
                case 12:
                    Task12();
                    break;
                case 13:
                    Task13();
                    break;
                case 14:
                    Task14();
                    break;

                default:
                    Console.WriteLine("EROR");
                    break;
            }
        }
    }

    static void Task1()
    {
        Console.Write("Введите число в двоичной системе: ");
        string x0 = Console.ReadLine();
        int x1 = Convert.ToInt32(x0, 2);
        string N = Convert.ToString(x1, 16);
        Console.WriteLine($"Число в шестнадцатеричной системе: {N}");
    }
    static void Task2()
    {
        Console.Write("Введите число в двоичной системе: ");
        string x0 = Console.ReadLine();
        string[] P = x0.Split('.');
        string P1 = P[0];
        string P2 = P.Length > 1 ? P[1] : "";
        int D0 = Convert.ToInt32(P1, 2);
        double D1 = 0;
        for (int i = 0; i < P2.Length; i++)
        {
            D1 += (P2[i] - '0') * Math.Pow(2, -(i + 1));
        }
        double D2 = D0 + D1;
        Console.WriteLine($"Десятичное число: {D2}");
    }
    static void Task3()
    {
        Console.Write("Введите число в двоичной системе: ");
        string x0 = Console.ReadLine();
        string[] p0 = x0.Split('.');
        string P1 = p0[0];
        string P2 = p0.Length > 1 ? p0[1] : "";
        int D2 = Convert.ToInt32(P1, 2);
        double D0 = 0;
        for (int i = 0; i < P2.Length; i++)
        {
            D0 += (P2[i] - '0') * Math.Pow(2, -(i + 1));
        }
        double D1 = D2 + D0;
        string N = Convert.ToString((int)D2, 8);
        Console.WriteLine($"Число в восьмеричной системе: {N}");
    }
    static void Task4()
    {
        Console.Write("Введите число в двоичной системе: ");
        string x0 = Console.ReadLine();
        string[] p0 = x0.Split('.');
        string P1 = p0[0];
        string P2 = p0.Length > 1 ? p0[1] : "";
        int D0 = Convert.ToInt32(P1, 2);
        double D1 = 0;
        for (int i = 0; i < P2.Length; i++)
        {
            D1 += (P2[i] - '0') * Math.Pow(2, -(i + 1));
        }
        double D2 = D0 + D1;
        string N = Convert.ToString((int)D2, 16);
        Console.WriteLine($"Число в шеснадцатеричной системе: {N}");
    }
    static void Task5()
    {
        int[] Arr = new int[15];
        Console.WriteLine("Введите 15 двузначных чисел:");
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Arr.Length; i++)
        {
            string S1 = Arr[i].ToString();
            char[] Arr1 = S1.ToCharArray();
            Array.Reverse(Arr1);
            Arr[i] = int.Parse(new string(Arr1));
        }
        Console.WriteLine("Новая разрядность:");
        foreach (int N in Arr)
        {
            Console.WriteLine(N);
        }
    }
    static void Task6()
    {
        int n = 9;
        int[] Arr = new int[n];
        Console.WriteLine("Введите элементы массива в восьмиричной системе:");
        for (int i = 0; i < n; i++)
        {
            Arr[i] = Convert.ToInt32(Console.ReadLine(), 8);
        }
        Console.WriteLine("Числа в десятичной системе:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Arr[i]);
        }
    }
    static void Task7()
    {
        int[] Arr = new int[7];
        Console.WriteLine("Введите 7 двузначных чисел:");
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Arr.Length; i++)
        {
            string S1 = Arr[i].ToString();
            Arr[i] = int.Parse(S1[0].ToString());
        }
        Console.WriteLine("Старшие разряды чисел:");
        foreach (int N in Arr)
        {
            Console.WriteLine(N);
        }
    }
    static void Task8()
    {
        double[] arr1 = new double[7];
        double[] arr2 = new double[9];
        Console.WriteLine("Введите 7 чисел для первого массива:");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Введите 9 чисел для второго массива:");
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = double.Parse(Console.ReadLine());
        }
        double[] Arr3 = arr1.Concat(arr2).ToArray();
        double[] Arr4 = Arr3.OrderByDescending(x => x).ToArray();
        Console.WriteLine("Массив упорядоченных чисел:");
        foreach (double N in Arr4)
        {
            Console.WriteLine(N);
        }
    }
    static void Task9()
    {
        int n = 12;
        List<int> arr = new List<int>(n);
        Dictionary<int, int> C = new Dictionary<int, int>();
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            int N = int.Parse(Console.ReadLine());
            arr.Add(N);
            if (C.ContainsKey(N))
            {
                C[N]++;
            }
            else
            {
                C[N] = 1;
            }
        }
            foreach (var P in C)
            {
                if (P.Value > 2)
                {
                arr.RemoveAll(x => x == P.Key);
                }
            }
            Console.WriteLine("Массив после редактирования:");
            foreach (int N in arr)
            {
                Console.WriteLine(N);
            }
    }
        static void Task10()
        {
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
            arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Повторяющиеся элементы найдены на позициях {i} и {j}");
                    }
                }
            }
        }
        static void Task11()
        {
            Console.Write("Введите двоичное число: ");
            string N1 = Console.ReadLine();
            int N2 = Convert.ToInt32(N1, 2);
            string arr1 = Convert.ToString(N2, 2).PadLeft(8, '0');
            char[] arr = arr1.ToCharArray();
            char[] arr2 = new char[8];
            for (int i = 0; i < 8; i++)
            {
                arr2[i] = arr[(i + 2) % 8];
            }
            string B1 = new string(arr2);
            int D1 = Convert.ToInt32(B1, 2);
            int D = N2 - D1;
            Console.WriteLine($"Разность исходного и полученного после сдвига числа: {D}");
        }
        static void Task12()
        {
            int n = 10;
             int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine(), 2);
        }
            Array.Sort(arr);
            Array.Reverse(arr);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Convert.ToString(arr[i], 2));
            }
                Console.WriteLine($"Сумма чисел: {sum}");
        }
        static void Task13()
        {
            int n = 10;
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine(), 2);
        }
            Array.Sort(arr);
            double sum = 0;
            for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
            double V1 = sum / n;
            Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Convert.ToString(arr[i], 2));
        }
            Console.WriteLine($"Среднее значение чисел: {V1}");
        }
        static void Task14()
        { 
            int n = 10;
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine(), 2);
            }
            int max = Array.IndexOf(arr, arr.Max());
            int min = Array.IndexOf(arr, arr.Min());
            int temp = arr[max];
            arr[max] = arr[min];
            arr[min] = temp;
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Convert.ToString(arr[i], 2));
            }
    }
}