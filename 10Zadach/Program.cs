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
        string name = "Георгий"; //имя
        string surname = "Естенский";// фамилия
        string patronymic = "Саидович"; // отчество
        int age = 19;// количество лет 

        /// <summary>
        /// вывод в консоль
        /// </summary>
        public void NameWrite()
        {
            Console.WriteLine(surname + " " + name + " " + patronymic + " " + age);
        }

    }

    class UserInput // организован ввод пользователем .|| хотел сделать наследованием чтобы добавить 1 метод но не получилось
    {
        string name; //имя
        string surname;// фамилия
        string patronymic; // отчество
        int age;// количество лет 

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

        /// <summary>
        /// вывод в консоль
        /// </summary>
        public void NameWrite()
        {
            Console.WriteLine(surname + " " + name + " " + patronymic + " " + age);
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
        float clockRate = (float)4.3; // тактовая частота
        int volumeRAM = 16; // обьем оперативки
        int volumeHDD = 1000; // обьем жесткого

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

    class PersonalComputerImput
    {
        float clockRate = (float)4.3; // тактовая частота
        int volumeRAM = 16; // обьем оперативки
        int volumeHDD = 1000; // обьем жесткого

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
        string model = "HUAWEI MateBook D 15"; // модель
        float clockRate = (float)4.3; // частота
        int volumeRAM = 16;  // обьем оперы
        int volumeHDD = 1000; // обьем жесткого
        float mass = (float)1.88; // вес

        /// <summary>
        /// вывести онфу о ноутбуке
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

    /// <summary>
    /// Класс «Смартфон», имеющий поля модель, тактовая частота 
    ///процессора, объем оперативной памяти, объем постоянной памяти, тип
    ///операционной системы, масса и свойство Info, выводящее информацию о
    ///смартфоне в виде строки.
    /// </summary>
    class Phone
    {
        string model = "HUAWEI NOVA 5T"; // модель
        float clockRate = (float)2.3; // частота проца
        int volumeRAM = 6; // обьем оперы
        int volumeHDD = 128; // обьем постоянной
        float mass = (float)300; // вес

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

    /// <summary>
    /// Объект «Треугольник» имеющий поля с длинами сторон, и 
    ///методы,вычисляющие периметр и выводящий длины сторон, а также
    ///периметр треугольника на экран.
    /// </summary>
    class Rectangle
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

        /// <summary>
        /// найти периметр
        /// </summary>
        public void GetPeriment()
        {
            decimal periment = ((lu[0] - ru[1]) + (ru[1] - rd[1])) * 2;//периметр

            Console.WriteLine("Периметр прямоугольника - " + periment);
        }

        /// <summary>
        /// найти площадь
        /// </summary>
        public void GetSquare()
        {
            decimal square = (lu[0] - ru[1]) * (ru[1] - rd[1]); // площадь

            Console.WriteLine("Площадь прямоугольника - " + square);
        }
    }

    /// <summary>
    /// Объект «Треугольник» имеющий поля с длинами сторон, и 
    ///методы,вычисляющие периметр и выводящий длины сторон, а также
    ///периметр треугольника на экран.
    /// </summary>
    class Triangle
    {
        int sideAB; // стороны
        int sideBC;
        int sideCA;

        // внести размеры
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

    /// <summary>
    /// Класс «Почтовое отправление», содержащий поля адреса 
    /// получателя: индекс, город, улица, дом, корпус, квартира, а также, тело
    /// письма(сообщение), и метод, выводящий адрес в виде строки.
    /// </summary>
    class MailSend
    {
        int index = 170001;// индекс
        string city = "тверь";// город
        string street = "ул.Спартака";//улица
        int house = 39;// дом
        int corps = 0;//корпус
        int numApartment = 400;// номер квартиры

        string texyLetter;//текст письма 

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

    /// <summary>
    /// Класс «Окружность», содержащая поля с координатами центра 
    /// окружности и радиуса, а также методы, вычисляющие длину окружности и
    ///площадь.
    /// </summary>
    class Circumference
    {
        public int[] center = new int[2];//кординвты центра
        int radius = 15; // радиус

        /// <summary>
        /// ввести радиус
        /// </summary>
        public void GenRadius()
        {
            Console.Write("Введите значение радиуса = ");

            radius = Convert.ToInt32(Console.ReadLine());
        }

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

    class Square
    {
        int[] lu = new int[2]; // координаты верхней левой
        int len = 10; // длинна стороны

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
}



