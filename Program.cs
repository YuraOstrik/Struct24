using System;


// namespace Practica
//{
//    class Program
//    {
//        delegate bool Number(int number);
//        static bool Chet(int number)
//        {
//            return number % 2 == 0;
//        }
//        static bool Nechet(int number)
//        {
//            return number % 2 != 0;
//        }
//        static bool Proste(int number)
//        {
//            if (number < 2)
//                return false;
//            for (int i = 2; i * i <= number; i++)
//            {
//                if (number % i == 0)
//                    return false;
//            }
//            return true;
//        }

//        static bool Fibonacci(int number)
//        {
//            int a = 0;
//            int b = 1;
//            while (b < number)
//            {
//                int temp = b;
//                b = a + b;
//                a = temp;
//            }
//            return b == number || number == 0;
//        }

//        static int[] Arr(int[] array, Number pred)
//        {
//            List<int> res = new List<int>();
//            foreach (int number in array)
//            {
//                if (pred(number))
//                {
//                    res.Add(number);
//                }
//            }
//            return res.ToArray();
//        }
//        static void Main(string[] args)
//        {
//            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int[] chetni = Arr(c, Chet);
//            int[] nechetni = Arr(c, Nechet);
//            int[] proste = Arr(c, Proste);
//            int[] fibonacci = Arr(c, Fibonacci);

//            Console.WriteLine("Четные числа: " + string.Join(", ", chetni));
//            Console.WriteLine("Нeчетные числа: " + string.Join(", ", nechetni));
//            Console.WriteLine("Простые числа: " + string.Join(", ", proste));
//            Console.WriteLine("Фибоначчи числа: " + string.Join(", ", fibonacci));

//        }
//    }
//}




 namespace Practica
{
    class Program
    {
        delegate void Print();

        static void Time()
        {
            Console.WriteLine("Время: " + DateTime.Now.ToString("HH::mm:ss"));
        }

        static void Data()
        {
            Console.WriteLine("Дата: " + DateTime.Now.ToString("dd.MM.yyyy"));
        }

        static void Week()
        {
            Console.WriteLine("День недели: " + DateTime.Now.DayOfWeek);
        }

        static void Tre()
        {
            Console.Write("Oснование треугольника: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Bысотa треугольника: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь: {0.5 * length * height}");
        }

        static void Prama()
        {
            Console.Write("Длина прямоугольника: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Ширина прямоугольника: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь: {length * width}");
        }

        static void Main(string[] args)
        {
            Print[] pred = { Time, Data, Week, Tre, Prama };

            int c = 0;
            while (c != 5)
            {
                Console.WriteLine("\nВыберите:");
                Console.WriteLine("1 - Показать время");
                Console.WriteLine("2 - Показать дату");
                Console.WriteLine("3 - Показать день недели");
                Console.WriteLine("4 - Посчитать площадь треугольника");
                Console.WriteLine("5 - Посчитать площадь прямоугольника");

                Console.Write("Выбор: ");
                c = int.Parse(Console.ReadLine());
                if (c >= 1 && c <= 5)
                {
                    pred[c - 1]();
                }
            }
        }
    }
}
