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
            Console.WriteLine($"Скорость : {speed}; Цвет : {color}; Мотор : {Motor}; Категория прав : {CategoryofRights}; Модель : {model}; Арендован на этот момент: {isArended}");
        }
        public Boat(int speed, string color, string CategoryofRights, string Motor, bool isArended, string model)
        {

        }
    }
}