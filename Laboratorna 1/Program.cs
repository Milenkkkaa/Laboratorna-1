using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ширину: ");
            double sWidth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть довжину: ");
            double sLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть висоту: ");
            double sHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть кількість кімнат: ");
            int sRoom = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введіть кiлькiсть поверхiв: ");
            int sFloor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введіть цiну будинку: ");
            int sPrice = Convert.ToInt16(Console.ReadLine());
            Console.Write("Чи є меблi та технiка? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasForniture = Console.ReadKey();
            Console.WriteLine();
            House OurHouse = new House();
            OurHouse.Width = sWidth;
            OurHouse.Length = sLength;
            OurHouse.Height = sHeight;
            OurHouse.Room = sRoom;
            OurHouse.Floor = sFloor;
            OurHouse.Price = sPrice;
            OurHouse.HasForniture = keyHasForniture.Key == ConsoleKey.Y ? true : false;
            double Volume = OurHouse.GetVolume();
            Console.WriteLine();
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Данi про об'єкт: ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Ширина: " + OurHouse.Width);
            Console.WriteLine("Довжина: " + OurHouse.Length);
            Console.WriteLine("Висота: " + OurHouse.Height);
            Console.WriteLine("Кiлькість кiмнат: " + OurHouse.Room);
            Console.WriteLine("Кiлькість поверхiв: " + OurHouse.Floor);
            Console.WriteLine("Цiна будинку: " + OurHouse.Price);
            Console.WriteLine(OurHouse.HasForniture ? "У будинку є меблi та технiка" : "У будинку немає меблiв та технiки");
            Console.WriteLine();
            Console.WriteLine("Будiвельний об'єм: " + Volume.ToString("0.00"));
            Console.ReadKey();
        }   
    }
}
