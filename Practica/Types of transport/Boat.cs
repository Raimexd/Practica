using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Boat : Transport
    {

        public override void AboutTransport()
        {
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Мотор : {Motor}; Категория прав : {CategoryofRights}; Модель : {model}; Арендован на этот момент: {IsArended}");
        }
        public Boat(int speed, string color, string CategoryofRights, string Motor, bool rent, string model)
        {
            this.speed = speed;
            this.color = color;
            this.CategoryofRights = CategoryofRights;
            this.Motor = Motor;
            this.Wheels = 0;
            this.IsArended = rent;
            this.model = model;
        }
    }
}