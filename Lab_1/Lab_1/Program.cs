using static System.Console;
namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"task - 1\n");
            Write("Введiть об'єм куба v: ");
            double v = double.Parse(ReadLine());
            double edge = Math.Pow(v, 1.0 / 3.0);
            WriteLine($"Ребро куба: {edge:F2}");

            WriteLine($"\ntask - 2\n");
            Write("Введiть двозначне число: ");
            int number = int.Parse(ReadLine());
            int sum = (number / 10) + (number % 10);

            if (sum % 2 != 0)
            { 
                WriteLine($"Сума цифр ({sum}) є непарною."); 
            }
            else
            { 
                WriteLine($"Сума цифр ({sum}) є парною."); 
            }

            WriteLine($"\ntask - 3\n");
            Write("Введiть x: ");
            double x = double.Parse(ReadLine());
            Write("Введiть y: ");
            double y = double.Parse(ReadLine());

            bool onBoundary = (y == -Math.Abs(x) && y >= -100) || (y == -100 && Math.Abs(x) <= 100);

            bool inside = (y < -Math.Abs(x)) && (y > -100);

            if (onBoundary)
            {
                WriteLine("На межi");
            }
            else if (inside)
            {
                WriteLine("Так");
            }
            else
            {
                WriteLine("Нi");
            }

            WriteLine($"\ntask - 4\n");
            Write("Введiть кiлькiсть днiв n: ");
            if (int.TryParse(ReadLine(), out int n) && n > 0)
            {
                DateTime pastDate = DateTime.Now.AddDays(-n);
                WriteLine($"Невiдома дата: {pastDate.ToShortDateString()}");
            }
            else
            {
                WriteLine("Будь ласка, введiть коректне додатне число.");
            }

            WriteLine($"\ntask - 5\n");
            Write("Введiть перше цiле число: ");
            int num1 = int.Parse(ReadLine());

            Write("Введiть друге цiле число: ");
            int num2 = int.Parse(ReadLine());

            long task5Result = SquareOfSum(num1, num2);
            WriteLine($"Квадрат суми ({num1} + {num2})^2 = {task5Result}");

            WriteLine("\n" + new string('-', 30) + "\n");

            WriteLine($"\ntask - 6\n");
            try
            {
                Write("Введiть значення a (дiйсне число): ");
                double a = double.Parse(ReadLine());

                Write("Введiть значення b (дiйсне число): ");
                double b = double.Parse(ReadLine());

                if (Math.Abs(a + b) < 1e-9)
                {
                    WriteLine("Помилка: Знаменник (a + b) не може дорiвнювати нулю.");
                }
                else
                {
                    double part1 = 5;
                    double part2 = b / (Math.Pow(b, 2) + 1);
                    double part3 = (a - b) * (1 / (a + b));

                    double finalResult = part1 + part2 + part3;

                    WriteLine($"Результат виразу: {finalResult:F4}");
                }
            }
            catch (FormatException)
            {
                WriteLine("Помилка: Будь ласка, вводьте лише числа.");
            }

            WriteLine("\nНатисніть будь-яку клавiшу, щоб вийти...");
            ReadKey();
        }
        static long SquareOfSum(int a, int b)
        {
            long sum = (long)a + b;
            return sum * sum;
        }
    }
}
