using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace ClassLibraryTasks
{
    public class Task1
    {
        public static void Bonding(string name, string surname, string age, string height, string weight)
        {
            Console.WriteLine(name + " " + surname + ": " + age + " лет, " + height + " см., " + weight + " кг.");
        }

        public static void FormOut(string name, string surname, string age, string height, string weight)
        {
            Console.WriteLine("{0} {1}: {2} лет, {3} см., {4} кг.", name, surname, age, height, weight);
        }

        public static void BestOut(string name, string surname, string age, string height, string weight)
        {
            Console.WriteLine($"{name} {surname}: {age} лет, {height} см., {weight} кг.");
        }

        public static void TaskOne()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост: ");
            string height = Console.ReadLine();

            Console.WriteLine("Введите ваш вес: ");
            string weight = Console.ReadLine();

            Bonding(name, surname, age, height, weight);
            FormOut(name, surname, age, height, weight);
            BestOut(name, surname, age, height, weight);

        }
    }

    public class Task2
    {
        public static void TaskTwo()
        {
            Console.WriteLine();
            Console.WriteLine("Задача 2");
            Console.WriteLine("Введите вес в килограммах: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Ваш индекс массы тела: " + weight / height / height);

        }
    }

    public class Task3
    {
        public static void TaskThree()
        {
            Console.WriteLine();
            Console.WriteLine("Задача 3");
            Console.WriteLine("Введите координату х1: ");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y1: ");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату х2: ");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y2: ");
            float y2 = float.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            string result = string.Format("{0:f2}", distance);

            Console.WriteLine("Расстояние между точками: " + result);

        }
    }

    public class Task4
    {
        public static void TaskFourThree()
        {
            Console.WriteLine();
            Console.WriteLine("Задача 4. Метод 1");
            Console.WriteLine("Введите значение а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"В результате перестановки по методу 1: a = {a}; b = {b}");

        }

        public static void TaskFourTwo()
        {
            Console.WriteLine();
            Console.WriteLine("Задача 4. Метод 2");
            Console.WriteLine("Введите значение а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            a = b * a;
            b = a / b;
            a = a / b;
            Console.WriteLine($"В результате перестановки по методу 2: a = {a}; b = {b}");

        }
    }

    public class Task5
    {
        public static void JustOutput(string name, string surname)
        {
            Console.WriteLine();
            Console.WriteLine("Просто вывод данных: ");
            Console.WriteLine(name + " " + surname);
            Console.WriteLine();
        }

        public static void PrintCenter(string name, string surname)
        {
            Console.WriteLine("Вывод данных в середине экрана: ");
            Console.SetCursorPosition((Console.WindowWidth - name.Length - surname.Length) / 2, Console.CursorTop);
            Console.WriteLine(name + " " + surname);
        }

        public static void TaskFive()
        {
            Console.WriteLine();
            Console.WriteLine("Задача 5");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            JustOutput(name, surname);
            PrintCenter(name, surname);
        }
    }
}
