using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    internal class ГрузовойАвтомобиль : Автомобиль, IInfo
    {
        protected float capacity;

        public ГрузовойАвтомобиль(string pName, int pPrice, int pSpeed, float pCapacity) : base(pName, pPrice, pSpeed)
        {
            this.capacity = pCapacity;
        }
        public void GetInfo()
        {
            Console.WriteLine(name + " вместимость: " + capacity);
        }
    }
}
