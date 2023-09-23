using System;
using System.Collections.Generic;
using System.Linq;
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
        float clockRate;
        int volumeRAM;
        int volumeHDD;

        public void imchangeParaparameters()
        {
            Console.WriteLine("Введите по очереди Тактовую частоту, обьем оперативки, Обьем HDD");

            //clockRate = Console.ReadLine(); //имя
            //volumeRAM = Console.ReadLine(); // фамилия
            //volumeHDD = Console.ReadLine(); // отчество
        }

        public void Info()
        {
            Console.WriteLine("Копмбютер имеет следующие характеристики:" + "\n" +
                "Чатота процессора - " + clockRate + '\n' +
                "Обьем оперативной памяти - " + volumeRAM + '\n' +
                "Обьем жесткого диска - " + volumeHDD);
        }

    }

}



