class Program
{
    static void Main(string[] args)
    {
        int a;
        do
        {
            Console.WriteLine(" " + '\n' + "Выберете штуку, которую хотите запустить: " + '\n' + "1. Игрулька 'Угадай число'" +
            '\n' + "2. Таблица умножения" + '\n' + "3. Вывод делителей числа" + '\n' + "4. Закрыть программу" + '\n' + " ");
            string oparation = Console.ReadLine();
            a = Convert.ToInt32(oparation);
            if (a == 1)
            {
                Guess_the_number();
            }

            if (a == 2)
            {
                Multiplication_Table();
            }

            if (a == 3)
            {
                Divisor_number();
            }

        } while (a != 4);
    }

    static void Guess_the_number()
    {
        Console.WriteLine("Угадайте число от 0 до 100 погнали!");
        Random number = new Random();
        int k = number.Next(0, 100);
        int b;
        do
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b > k)
            {
                Console.WriteLine("Меньше");
            }
            if (b < k)
            {
                Console.WriteLine("Больше");
            }
        } while (k != b);
        Console.WriteLine("Хорош это было нереально трудно!");
    }

    static void Multiplication_Table()
    {
        Console.WriteLine();
        Console.WriteLine("Таблица умножения: ");
    
        int[,] table1 = new int[10, 10];
        for (int i = 1; i < table1.GetLength(0); i++)
        {
            for (int n = 1; n < table1.GetLength(1); n++)
            {
                Console.Write(table1[i, n] + (i * n) + "\t");
            }
            Console.WriteLine();
        }
        
    }

    static void Divisor_number()
    {
        string str = "";
        Console.WriteLine("");
        Console.WriteLine("Введите число: ");
        int y = Convert.ToInt32(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i < y; i++)
        {
            if (y % i == 0)
            {
                numbers.Add(i);
            }
        }
        foreach (int i in numbers)
        {
            str = str + i.ToString() + '\t';
        }
        Console.WriteLine("");
        Console.WriteLine("Ты сможешь " + y.ToString() + " разделить на: " + '\n' + str);
    }
}
