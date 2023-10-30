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
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Кол-во колес : {Wheels}; Категория прав : {CategoryofRights}; Модель : {model}; Арендован на этот момент: {isArended}");
        }
        public Bike(int speed, string color, string CategoryofRights, string Motor, int Wheels, bool isArended, string model)
        {

        }
    }
}
