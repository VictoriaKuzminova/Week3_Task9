using System;
using System.Text;
using System.IO;


namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            while (true)
            {
                try {
                    Console.Write("Введите букву: ");
                    ch = Convert.ToChar(Console.Read());
                    break;
                }
                catch { Console.WriteLine("Некорректный ввод данных"); }
            }
            const string path = "text.txt";
            Console.WriteLine("Найденные строки по критерию: ");
            int a = 0;
            foreach (var str in File.ReadAllLines(path))
            {
                if (str.StartsWith(ch.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(str);
                    a++;
                    continue;
                }

            }
            if (a >= 1)
            {
                Environment.Exit(0);
            }
            else
             Console.WriteLine("Строка не найдена");
            
        }
    }
}
