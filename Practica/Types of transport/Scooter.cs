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
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Кол-во колес : {Wheels}; Модель : {model}; Арендован на этот момент: {isArended}");
        }
        public Scooter(int speed, string color, string CategoryofRights, int Wheels, bool isArended, string model)
        {

        }
    }
}

