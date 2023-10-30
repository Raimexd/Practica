using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{

    internal class List
    {
        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>();
            transports.Add(new Boat(20, "Черный", "Хороший", "Б", false, "A-123"));
            transports.Add(new Bycycle(7, "Черный", "Хороший", "Б", 2, false, "ГГВП"));
            transports.Add(new Car(80, "Черный", "А", "Норм", 4, false, "БМГ"));
            transports.Add(new Bike(60, "Черный", "Ф", "Приятный Для Поездки", 2, true, "БВ-144"));
            transports.Add(new Scooter(5, "Черный", "Б", 2, false, "РЯВ"));

            while (true)
            {
                //Console.WriteLine("Выберите тип транспорта для вывода:");
                //Console.WriteLine("1. Весь транспорт");
                //Console.WriteLine("2. Лодки");
                //Console.WriteLine("3. Машины");
                //Console.WriteLine("4. Мотоциклы");
                //Console.WriteLine("5. Велосипеды");
                //Console.WriteLine("6. Самокаты");
                //Console.WriteLine("0. Выйти");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Весь транспорт:");
                        foreach (var transport in transports)
                        {
                            transport.AboutTransport();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Наши Лодки:");
                        foreach (var transport in transports)
                        {
                            if (transport is Boat)
                            {
                                transport.AboutTransport();
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Наши Машины:");
                        foreach (var transport in transports)
                        {
                            if (transport is Car)
                            {
                                transport.AboutTransport();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Наши Мотоциклы:");
                        foreach (var transport in transports)
                        {
                            if (transport is Bike)
                            {
                                transport.AboutTransport();
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Наши Велосипеды:");
                        foreach (var transport in transports)
                        {
                            if (transport is Bycycle)
                            {
                                transport.AboutTransport();
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Наши Самокаты:");
                        foreach (var transport in transports)
                        {
                            if (transport is Scooter)
                            {
                                transport.AboutTransport();
                            }
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Выбор не распознан. Пожалуйста, выберите снова.");
                        break;
                }
            }
        }
    }
}
