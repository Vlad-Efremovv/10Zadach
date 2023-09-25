using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            try
            {

                int way = Convert.ToInt16(Console.ReadLine());

                switch (way)
                {

                    case 1:

                        ///Point point = new Point();


                        break;
                    case 2:

                        if (ChoosingWayInput())
                        {
                            UserInput userInput = new UserInput();
                            userInput.NameRed();
                            userInput.NameWrite();

                        }
                        else
                        {
                            User user = new User();
                            user.NameWrite();
                        }

                        break;

                    case 3:

                        if (ChoosingWayInput())
                        {
                            PersonalComputerImput personalComputerImput = new PersonalComputerImput();
                            personalComputerImput.GetInfo();
                            personalComputerImput.Info();
                        }
                        else
                        {
                            PersonalComputer personalComputer = new PersonalComputer();
                            personalComputer.Info();
                        }

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

                        rectangle.GetPeriment(); // найти пемиметр 
                        rectangle.GetSquare(); // найти площадь 

                        break;
                    case 7:
                        Triangle triangle = new Triangle();

                        triangle.GetSideLengths();

                        Console.WriteLine();
                        triangle.TriangleInformation(triangle.GetPeriment());

                        break;

                    case 8:

                        MailSend mailSend = new MailSend();

                        //mailSend.WriteInfo();
                        mailSend.OutputInfo();

                        break;

                    case 9:

                        Circumference circumference = new Circumference();

                        //circumference.GenRadius(); //ввести радиус самому

                        double len = circumference.LengthCircumference(); // получить длиннну окружности
                        Console.WriteLine("Длинна окружности = " + len);

                        double area = circumference.AreaCircumference();// получить площадь 
                        Console.WriteLine("Площать окружности = " + area);

                        break;
                    case 10:

                        Square square = new Square();

                        Console.WriteLine("Периметр квадрата = " + square.GetPeriment());
                        Console.WriteLine("Полщадь квадрата = " + square.GetSquare());

                        break;
                    default:
                        Console.WriteLine("Ошибка выбора задания!");
                        break;
                }

                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.Write("Ошибка!");
                throw;
            }
        }

        static bool ChoosingWayInput()
        {
            Console.Write("Вы хотите сами вводить данные? 0(нет)/1(да) - ");

            int flag = Convert.ToInt32(Console.ReadLine());

            bool way = false;

            if (flag > 0)
            {
                way = true;
            }

            return way;
        }

    }

    /// <summary>
    /// Класс «Точка», имеющего поля X, Y, Z и метод перемещения 
    ///MoveBy(dx, dy, dz), смещающий точку на заданные значения по X, Y, Z.
    /// </summary>
    internal class Point
    {
        int x = 0,
            y = 0,
            z = 0;
        ///не понял суть задания 
    }

    /// <summary>
    /// Класс «Пользователь»имеющий поля фамилия, имя, отчество и 
    ///возраст, а также метод ФИО, выводящее фамилию, имя и отчество, 
    ///разделенные пробелами в виде строки.
    /// </summary>
    internal class User
    {
        protected string name = "Георгий"; //имя
        protected string surname = "Естенский";// фамилия
        protected string patronymic = "Саидович"; // отчество
        protected int age = 19;// количество лет 

        /// <summary>
        /// вывод в консоль
        /// </summary>
        public void NameWrite()
        {
            Console.WriteLine(surname + " " + name + " " + patronymic + " " + age);
        }

    }

    class UserInput : User // организован ввод пользователем
    {
        /// <summary>
        /// внести данные
        /// </summary>
        public void NameRed()
        {
            Console.WriteLine("Введите по очереди имя, фамилию, oтчество, возраст");

            name = Console.ReadLine(); //имя
            surname = Console.ReadLine(); // фамилия
            patronymic = Console.ReadLine(); // отчество
            age = Convert.ToInt32(Console.ReadLine()); // количество лет 
        }
    }

    /// <summary>
    /// Класс «Персональный компьютер»,имеющий поля модель, 
    ///тактовая частота процессора,объем оперативной памяти, объем
    ///жесткого диска и метод Info, выводящий информацию о персональном
    ///компьютере в виде строки.
    /// </summary>
    class PersonalComputer
    {
        protected float clockRate = (float)4.3; // тактовая частота
        protected int volumeRAM = 16; // обьем оперативки
        protected int volumeHDD = 1000; // обьем жесткого

        /// <summary>
        /// вывод информации о пк
        /// </summary>
        public void Info()
        {
            Console.WriteLine("Копмбютер имеет следующие характеристики:" + "\n" +
                "Чатота процессора - " + clockRate + " Ггц" + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + " гигабайт" + '\n' +
                "Обьем жесткого диска - " + volumeHDD + " гигабайт");
        }
    }

    class PersonalComputerImput : PersonalComputer
    {
        /// <summary>
        /// Ввести данные
        /// </summary>
        public void GetInfo()
        {
            Console.Write("Частота процессора = ");
            clockRate = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Обьем RAM = ");
            volumeRAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Обьем HDD = ");
            volumeHDD = Convert.ToInt32(Console.ReadLine());
        }
    }

    /// <summary>
    /// Класс «Ноутбук», имеющий поля модель, тактовая частота 
    ///процессора, объем оперативной памяти, объем жесткого диска, масса и
    ///метод Info, выводящий информацию о ноутбуке в виде строки.
    /// </summary>
    class Laptop
    {
        protected string model = "HUAWEI MateBook D 15"; // модель
        protected float clockRate = (float)4.3; // частота
        protected int volumeRAM = 16;  // обьем оперы
        protected int volumeHDD = 1000; // обьем жесткого
        protected float mass = (float)1.88; // вес

        /// <summary>
        /// вывести инфу о ноутбуке
        /// </summary>
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

    class LaptopInput : Laptop
    {
        public void GetInfo()
        {
            Console.Write("Модель ноутбука - ");
            model = Console.ReadLine();

            Console.Write("Частота процессора - ");
            clockRate = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Обьем оперативной памяти - ");
            volumeRAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Обьем жесткого диска - ");
            volumeHDD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Масса - ");
            mass = (float)Convert.ToDouble(Console.ReadLine());
        }
    }

    /// <summary>
    /// Класс «Смартфон», имеющий поля модель, тактовая частота 
    ///процессора, объем оперативной памяти, объем постоянной памяти, тип
    ///операционной системы, масса и свойство Info, выводящее информацию о
    ///смартфоне в виде строки.
    /// </summary>
    class Phone
    {
        protected string model = "HUAWEI NOVA 5T"; // модель
        protected float clockRate = (float)2.3; // частота проца
        protected int volumeRAM = 6; // обьем оперы
        protected int volumeHDD = 128; // обьем постоянной
        protected float mass = (float)300; // вес

        public void Info()
        {
            Console.WriteLine("Телефон имеет следующие характеристики:" + "\n" +
                "Модель - " + model + "\n" +
                "Чатота процессора - " + clockRate + " Ггц" + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + " гигабайт" + '\n' +
                "Обьем постоянной памяти - " + volumeHDD + " гигабайт \n" +
                "Масса - " + mass + " грамм");
        }
    }

    class PhoneInput : Phone
    {
        public void GetInfo()
        {
            Console.Write("Модель телеофна - ");
            model = Console.ReadLine();

            Console.Write("Частота процессора - ");
            clockRate = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Обьем оперативной памяти - ");
            volumeRAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Обьем постоянной памяти - ");
            volumeHDD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Масса - ");
            mass = (float)Convert.ToDouble(Console.ReadLine());
        }
    }

    /// <summary>
    /// Объект «Треугольник» имеющий поля с длинами сторон, и 
    ///методы,вычисляющие периметр и выводящий длины сторон, а также
    ///периметр треугольника на экран.
    /// </summary>
    class Rectangle
    {
        protected int[] lu = new int[2]; // правый левый
        protected int[] rd = new int[2]; // левый нижний 

        protected int[] ld = new int[2]; // правый левый
        protected int[] ru = new int[2]; // левый нижний 

        /// <summary>
        /// координаты известных точек
        /// </summary>
        public void KnownPoints()
        {
            lu[0] = 1;
            lu[1] = 4;

            rd[0] = 6;
            rd[1] = -2;

            GetUnknown();
        }

        /// <summary>
        /// найти 2 неизвестных точки при 2 известных 
        /// </summary>
        public void GetUnknown()
        {
            ld[0] = ld[0];
            ld[1] = rd[1];

            ru[0] = rd[0];
            ru[1] = ld[1];
        }

        /// <summary>
        /// найти периметр
        /// </summary>
        public void GetPeriment()
        {
            decimal periment = ((ru[0] - lu[0]) + (lu[1] - ld[1])) * 2;//периметр

            Console.WriteLine("Периметр прямоугольника - " + periment);
        }

        /// <summary>
        /// найти площадь
        /// </summary>
        public void GetSquare()
        {
            decimal square = (ru[0] - lu[0]) * (lu[1] - ld[1]); // площадь

            Console.WriteLine("Площадь прямоугольника - " + square);
        }
    }

    class RectangleInput : Rectangle
    {
        public void GetPoint()
        {
            Console.Write("Введити значение Х для верхней левой точки - ");
            lu[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введити значение Y для верхней левой точки - ");
            lu[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введити значение Х для нижней правой точки - ");
            rd[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введити значение Y для нижней правой точки - ");
            rd[1] = Convert.ToInt32(Console.ReadLine());

            GetUnknown();
        }
    }

    /// <summary>
    /// Объект «Треугольник» имеющий поля с длинами сторон, и 
    ///методы,вычисляющие периметр и выводящий длины сторон, а также
    ///периметр треугольника на экран.
    /// </summary>
    class Triangle
    {
        protected int sideAB = 10; // стороны
        protected int sideBC = 10;
        protected int sideCA = 10;

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

    class TriangleInput : Triangle
    {
        public void GetSideLengths()
        {
            Console.WriteLine("Введите длины сторон: \n");

            Console.Write("Сторона AB = ");
            sideAB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сторона BC = ");
            sideBC = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сторона CA = ");
            sideCA = Convert.ToInt32(Console.ReadLine());

            if (sideAB + sideBC < sideCA)
            {
                Console.WriteLine("Введены неправильные значения");
                Environment.Exit(0);
            }
            if (sideCA + sideBC < sideAB)
            {
                Console.WriteLine("Введены неправильные значения");
                Environment.Exit(0);
            }
            if (sideAB + sideCA < sideBC)
            {
                Console.WriteLine("Введены неправильные значения");
                Environment.Exit(0);
            }
        }
    }

    /// <summary>
    /// Класс «Почтовое отправление», содержащий поля адреса 
    /// получателя: индекс, город, улица, дом, корпус, квартира, а также, тело
    /// письма(сообщение), и метод, выводящий адрес в виде строки.
    /// </summary>
    class MailSend
    {
        protected int index = 170001;// индекс
        protected string city = "тверь";// город
        protected string street = "ул.Спартака";//улица
        protected int house = 39;// дом
        protected int corps = 0;//корпус
        protected int numApartment = 400;// номер квартиры

        protected string texyLetter;//текст письма 

        /// <summary>
        /// вывод адресса получателя
        /// </summary>
        public void OutputInfo()
        {
            Console.Write
                (
                    "Адрес получателя: " + index + ' '
                    + city + ' ' + street + house
                );

            if (corps != 0)
            {
                Console.Write(" корпус " + corps);
            }
            if (numApartment != 0)
            {
                Console.Write(" квартира " + numApartment);
            }
        }
    }

    class MailSendInput : MailSend
    {
        /// <summary>
        /// вписать данные получателя
        /// </summary>
        public void WriteInfo()
        {
            try
            {
                Console.WriteLine("Введите все данные:");

                Console.Write("Индекс = ");
                index = Convert.ToInt32(Console.ReadLine());

                Console.Write("город = ");
                city = Console.ReadLine();

                Console.Write("название улицы = ");
                street = Console.ReadLine();

                Console.Write("номер дома = ");
                house = Convert.ToInt32(Console.ReadLine());

                Console.Write("номер корпуса = ");
                try
                {
                    corps = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    corps = 0;
                }

                Console.Write("номер квартиры = ");
                try
                {
                    numApartment = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    numApartment = 0;
                }

                Console.WriteLine("Содерживое письма = ");
                texyLetter = Console.ReadLine();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    /// <summary>
    /// Класс «Окружность», содержащая поля с координатами центра 
    /// окружности и радиуса, а также методы, вычисляющие длину окружности и
    ///площадь.
    /// </summary>
    class Circumference
    {
        protected int[] center = new int[2];//кординвты центра
        protected int radius = 15; // радиус

        /// <summary>
        /// найти длинну окружности
        /// </summary>
        /// <returns></returns>
        public double LengthCircumference()
        {
            double lenCir = 2 * 3.14 * radius;

            return lenCir;
        }

        /// <summary>
        /// найти площадь
        /// </summary>
        /// <returns></returns>
        public double AreaCircumference()
        {
            double area = 3.14 * radius * radius;

            return area;
        }
    }

    class CircumferenceInput : Circumference
    {
        public void GetRadius()
        {
            Console.Write("Введите значение радиуса = ");

            radius = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Square
    {
        protected int[] lu = new int[2]; // координаты верхней левой
        protected int len = 10; // длинна стороны

        /// <summary>
        /// найти периметр
        /// </summary>
        /// <returns></returns>
        public int GetPeriment()
        {
            int perimetr = len * 4;

            return perimetr;
        }

        /// <summary>
        /// найти площадь
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            double square = len * len;

            return square;
        }
    }

    class SquareInput : Square 
    {
        public void GetLen()
        {
            Console.Write("Введите длину стороны - ");
            len = Convert.ToInt32(Console.ReadLine());
        }
    }
}



