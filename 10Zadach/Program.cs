using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                case 1:

                    break;
                case 2:

                    User user = new User();
                    user.nameRed();
                    user.nameWrite();

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
            Console.WriteLine("Введите по очереди фамилию, имя, oтчество, возраст");

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
}
