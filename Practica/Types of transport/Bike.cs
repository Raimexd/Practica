using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Bike : Transport
    {
        public override void AboutTransport()
        {
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Кол-во колес : {Wheels}; Категория прав : {CategoryofRights}; Модель : {model}; Арендован на этот момент: {IsArended}");
        }
        public Bike(int speed, string color, string CategoryofRights, string Motor, int Wheels, bool rent, string model)
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
