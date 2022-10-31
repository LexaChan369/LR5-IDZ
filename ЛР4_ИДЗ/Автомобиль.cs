using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    internal class Автомобиль : ТехСредство
    {
        protected int speed;

        public Автомобиль(string pName, int pPrice, int pSpeed) : base(pName, pPrice)
        {
            this.speed = pSpeed;
        }
    }
}
