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
            transports.Add(new Bike(60, "Черный",  "Ф", "Приятный Для Поездки", 2, true, "БВ-144"));
            transports.Add(new Scooter(5, "Черный", "Б", 2, false, "РЯВ"));

            Console.WriteLine("Весь транспорт:");
            foreach (var transport in transports) 
            {
                transport.AboutTransport();
            }

            Console.WriteLine("Наши Лодки:");
            foreach (var transport in transports)
            {
                if (transport is Boat)
                {
                    transport.AboutTransport();
                }
            }

            Console.WriteLine("Наши Машины:");
            foreach (var transport in transports)
            {
                if (transport is Car)
                {
                    transport.AboutTransport();
                }
            }

            Console.WriteLine("Наши мотоциклы:");
            foreach (var transport in transports)
            {
                if (transport is Bike)
                {
                    transport.AboutTransport();
                }
            }

            Console.WriteLine("Наши Велосипеды:");
            foreach (var transport in transports)
            {
                if (transport is Bycycle)
                {
                    transport.AboutTransport();
                }
            }

            Console.WriteLine("Наши Самокаты:");
            foreach (var transport in transports)
            {
                if (transport is Scooter)
                {
                    transport.AboutTransport();
                }
            }
        }
    }
}
