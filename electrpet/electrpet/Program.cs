using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrpet
{

    class Program
    {
        static void Main(string[] args)
        {

            Pets cat = new Pets();
            Console.WriteLine("Выберите функцию");
            Console.WriteLine("1) Присвоить имя");
            Console.WriteLine("2) Кормить");
            Console.WriteLine("3) Наказать");
            Console.WriteLine("4) Узнать возраст");
            Console.WriteLine("5) Состояние здоворья");
            Console.WriteLine("6) Выход");
            int m = 0;

            while (m != 6)
            {
                try
                {
                    m =int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Введите число!");
                    m = 0;
                }
               
                switch (m)
                {
                    case 1 :
                        Console.WriteLine("Введите имя");
                        cat.Name = Console.ReadLine();
                        Console.Write("Имя питомца: ");
                        Console.WriteLine(cat.Name);
                        break;
                    case 2:
                        cat.Feed();
                        Console.WriteLine("Питомец покормлен");
                        break;
                    case 3:
                        cat.Punish();
                        Console.WriteLine("Питомец наказан");
                        break;
                    case 4:
                        Console.WriteLine("Возраст питомца");
                        Console.WriteLine(cat.Age);
                        break;
                    case 5:
                        Console.Write("Состояние здоровья: ");
                        Console.WriteLine(cat.Color());
                        break;
                    case 6:
                        Console.Write("Для выхода нажмите любую кнопку");                        
                        break;
                    default:
                        Console.WriteLine("Не верна выбрана функция");
                        break;
                }
            }          
            Console.ReadKey();

        }
    }
}
