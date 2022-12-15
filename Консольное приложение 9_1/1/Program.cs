using System;
using System.Text;
using System.IO;


namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            int am;
            while (true)
            {
                try
                {
                    Console.Write("Введите количество элементов в массиве: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Минимальное значение 1");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            int[] mas = new int[n];
            for (int i = 0; i < n; ++i)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Элемент №[{0}]= ", i);
                        mas[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод");
                    }
                }
            }
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите начало диапозона: ");
                        a = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введите конец диапозона: ");
                        b = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                if (a > b)
                {
                    Console.WriteLine("Начальная точка диапазона не может быть больше конечной точки");
                    continue;
                }
                break;
            }
            FileStream f = new FileStream("text.dat", FileMode.Create);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; ++i)
            {
                fOut.Write(mas[i]);
            }
            fOut.Close();
            f.Close();
            f = new FileStream("text.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (long i = 0; i < m; i += 4)
            {
                f.Seek(i, SeekOrigin.Begin);
                am = fIn.ReadInt32();
                if ((am >= a) && (am <= b))
                {
                    Console.WriteLine( am); 
                }
            }
            fIn.Close();
            f.Close();

        }
    }
}
