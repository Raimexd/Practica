using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Bycycle : Transport
    {
        public override void AboutTransport()
        {
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Мотор : {Motor}; Кол-во колес : {Wheels}; Модель : {model}; Арендован на этот момент: {IsArended}");
        }
        public Bycycle(int speed, string color, string CategoryofRights, string Motor, int Wheels, bool rent, string model)
        {
            this.speed = speed;
            this.color = color;
            this.CategoryofRights = CategoryofRights;
            this.Motor = Motor;
            this.Wheels = 2;
            this.IsArended = rent;
            this.model = model;
        }
    }
}

