using System.Security.Cryptography.X509Certificates;

namespace проба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            

            while (true)
            {
                Console.WriteLine("Выберите операцию:");

                string operation = Console.ReadLine();
                int limit = Convert.ToInt32(operation);

                if (limit == 9)
                { break; }
                else if (limit < 1 || limit > 9)
                {
                    Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите число от 1 до 9.");
                    continue;
                };
                
                
                

                if (limit == 1)
                {
                    Console.WriteLine("Введите первое число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine("Введите второе число:");
                    string second = Console.ReadLine();
                    double b = Convert.ToDouble(second);

                    Console.WriteLine(a + b);
                };

                if (limit == 2)
                {
                    Console.WriteLine("Введите первое число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine("Введите второе число:");
                    string second = Console.ReadLine();
                    double b = Convert.ToDouble(second);

                    Console.WriteLine(a - b);
                };

                if (limit == 3)
                {
                    Console.WriteLine("Введите первое число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine("Введите второе число:");
                    string second = Console.ReadLine();
                    double b = Convert.ToDouble(second);

                    Console.WriteLine(a * b); 
                };

                if (limit == 4)
                {
                    Console.WriteLine("Введите первое число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine("Введите второе число:");
                    string second = Console.ReadLine();
                    double b = Convert.ToDouble(second);

                    Console.WriteLine(a / b);
                };

                if (limit == 5)
                {
                    Console.WriteLine("Введите число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine("Введите степень числа:");
                    string second = Console.ReadLine();
                    double b = Convert.ToDouble(second);

                    Console.WriteLine(Math.Pow(a, b));
                };

                if (limit == 6)
                {
                    Console.WriteLine("Введите число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine(Math.Pow(a, 0.5)); 
                };

                if (limit == 7)
                {
                    Console.WriteLine("Введите число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    Console.WriteLine(a / 100); 
                };

                if (limit == 8)
                {
                    Console.WriteLine("Введите число:");
                    string first = Console.ReadLine();
                    double a = Convert.ToDouble(first);

                    double x = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        x = x * i;
                    };

                    Console.WriteLine(x);
                };
            };
        }
    }
}