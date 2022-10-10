int oper;
do
{
    Console.Write("Введите номер операции: 1. Сложить 2 числа 2. Вычесть первое из второго 3. Перемножить два числа 4. Разделить первое на второе 5. Возвести в степень N первое число 7. Найти 1 процент от числа 8. Найти факториал из числа 9. Выйти из программы ");
    oper = Convert.ToInt32(Console.ReadLine());
    switch (oper)
    {
        case 1:
            Console.WriteLine("Введите два числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            break;
        case 2:
            Console.WriteLine("Введите два числа");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 - num4);
            break;
        case 3:
            Console.WriteLine("Введите два числа");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num5 * num6);
            break;
        case 4:
            Console.WriteLine("Введите два числа");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num7 / num8);
            break;
        case 5:
            Console.WriteLine("Введите два числа");
            int step0 = 1;
            int step1 = Convert.ToInt32(Console.ReadLine());
            int step2 = Convert.ToInt32(Console.ReadLine());
            for (int step = 0; step <= step2; step++)
            {
                step0 = step1 * step1;
            }
            Console.WriteLine(step0);
            break;
        case 7:
            int sot = 100;
            Console.WriteLine("Введите число");
            float num12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num12 / sot);
            break;
        case 8:
            Console.WriteLine("Введите число");
            int result = 1;
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fact; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
            break;
        case 9:
            Console.WriteLine("Завершить программу.");
            break;
    }
} while (oper != 9);