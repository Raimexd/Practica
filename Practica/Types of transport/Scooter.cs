using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Scooter : Transport
    {
        public override void AboutTransport()
        {
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Кол-во колес : {Wheels}; Модель : {model}; Арендован на этот момент: {IsArended}");
        }
        public Scooter(int speed, string color, string CategoryofRights, int Wheels, bool rent, string model)
        {
            this.speed = speed;
            this.color = color;
            this.CategoryofRights = CategoryofRights;
            this.Motor = Motor;
            this.Wheels = Wheels;
            this.IsArended = rent;
            this.model = model;
        }
    }
}

