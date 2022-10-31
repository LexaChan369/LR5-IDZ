using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    internal class ЛегковойАвтомобиль : Автомобиль, IInfo
    {
        protected int weight;
        public ЛегковойАвтомобиль(string pName, int pPrice, int pSpeed, int pWeight) : base(pName, pPrice, pSpeed)
        {
            this.weight = pWeight;
        }
        public void GetInfo()
        {
            Console.WriteLine(name + " вес: " + weight);
        }
    }
}
