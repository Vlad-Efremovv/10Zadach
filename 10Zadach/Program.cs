using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace _10Zadach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задния:");

            int way = Convert.ToInt16(Console.ReadLine());

            switch (way)
            {
                case 0:



                    break;
                case 1:
                    break;
                case 2:

                    User user = new User();
                    user.nameRed();
                    user.nameWrite();

                    break;

                case 3:
                    Personal_computer personal_computer = new Personal_computer();
                    personal_computer.Info();
                    break;
                case 4:
                    Laptop laptop = new Laptop();
                    laptop.Info();
                    break;
                case 5:
                    Phone phone = new Phone();
                    phone.Info();
                    break;
                case 6:
                    Rectangle rectangle = new Rectangle();

                    rectangle.KnownPoints(); //вписать известные точки
                    rectangle.GetUnknown(); // найти неивестные точки
                    rectangle.GetPeriment(); // найти пемиметр 
                    rectangle.GetSquare(); // найти площадь 

                    break;
                case 7:
                    Triangle triangle = new Triangle();

                    triangle.GetSideLengths();

                    Console.WriteLine();
                    triangle.TriangleInformation(triangle.GetPeriment());

                    break;

                default:
                    Console.WriteLine("Ошибка выбора задания!");
                    break;
            }

            Console.ReadLine();
        }
    }

    internal class Point
    {
        int x = 0,
            y = 0,
            z = 0;

    }

    internal class User
    {
        string name; //имя
        string surname;// фамилия
        string patronymic; // отчество
        int age;// количество лет 

        public void nameRed()
        {
            Console.WriteLine("Введите по очереди имя, фамилию, oтчество, возраст");

            name = Console.ReadLine(); //имя
            surname = Console.ReadLine(); // фамилия
            patronymic = Console.ReadLine(); // отчество
            age = Convert.ToInt32(Console.ReadLine()); // количество лет 
        }

        public void nameWrite()
        {
            Console.WriteLine(surname + " " + name + " " + patronymic + " " + age);
        }

    }


    class Personal_computer
    {
        float clockRate = (float)4.3;
        int volumeRAM = 16;
        int volumeHDD = 1000;

        public void Info()
        {
            Console.WriteLine("Копмбютер имеет следующие характеристики:" + "\n" +
                "Чатота процессора - " + clockRate + " Ггц" + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + " гигабайт" + '\n' +
                "Обьем жесткого диска - " + volumeHDD + " гигабайт");
        }

    }

    class Laptop
    {
        string model = "HUAWEI MateBook D 15";
        float clockRate = (float)4.3;
        int volumeRAM = 16;
        int volumeHDD = 1000;
        float mass = (float)1.88;

        public void Info()
        {
            Console.WriteLine("Ноутбук имеет следующие характеристики:" + "\n" +
                "Модель ноутбука - " + model + "\n" +
                "Чатота процессора - " + clockRate + " Ггц" + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + " гигабайт" + '\n' +
                "Обьем жесткого диска - " + volumeHDD + " гигабайт \n" +
                "Масса - " + mass + " кг");
        }
    }

    class Phone
    {
        string model = "HUAWEI NOVA 5T";
        float clockRate = (float)2.3;
        int volumeRAM = 6;
        int volumeHDD = 128;
        float mass = (float)300;

        public void Info()
        {
            Console.WriteLine("Телефон имеет следующие характеристики:" + "\n" +
                "Модель ноутбука - " + model + "\n" +
                "Чатота процессора - " + clockRate + " Ггц" + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + " гигабайт" + '\n' +
                "Обьем жесткого диска - " + volumeHDD + " гигабайт \n" +
                "Масса - " + mass + " грамм");
        }
    }

    class Rectangle // хуйня ебаная
    {
        public int[] ru = new int[2]; // правый левый
        public int[] ld = new int[2]; // левый нижний 

        int[] rd = new int[2]; // правый левый
        int[] lu = new int[2]; // левый нижний 

        /// <summary>
        /// внести координаты известных точек
        /// </summary>
        public void KnownPoints()
        {
            ru[0] = 1;
            ru[1] = 4;

            ld[0] = 6;
            ld[1] = -2;

            // можно перализовать с тем что пользователь сам их вводит 
            // через Console.ReadLine();
        }

        /// <summary>
        /// найти 2 неизвестных точки при 2 известных 
        /// </summary>
        public void GetUnknown()
        {
            rd[0] = ld[1];
            rd[1] = rd[0];

            lu[0] = rd[1];
            lu[1] = ld[0];
        }

        public void GetPeriment()
        {
            decimal periment = ((lu[0] - ru[1]) + (ru[1] - rd[1])) * 2;//периметр

            Console.WriteLine("Периметр прямоугольника - " + periment);
        }

        public void GetSquare()
        {
            decimal square = (lu[0] - ru[1]) * (ru[1] - rd[1]);

            Console.WriteLine("Площадь прямоугольника - " + square);
        }
    }

    class Triangle
    {
        int sideAB;
        int sideBC;
        int sideCA;

        public void GetSideLengths()
        {
            Console.WriteLine("Введите длины сторон: \n");

            Console.Write("Сторона AB = ");
            sideAB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сторона BC = ");
            sideBC = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сторона CA = ");
            sideCA = Convert.ToInt32(Console.ReadLine());
        }

        public int GetPeriment()
        {
            int perimetr = sideAB + sideBC + sideCA;
            return perimetr;
        }

        public void TriangleInformation(int perimetr)
        {
            Console.WriteLine("Треугольник имеет следующие данные :\n"
                + "Сторона AB = " + sideAB
                + "\nСторона BC = " + sideBC
                + "\nСторона CA = " + sideCA 
                + "\nПериметр треугольника = " + perimetr);
        }

    }

}



