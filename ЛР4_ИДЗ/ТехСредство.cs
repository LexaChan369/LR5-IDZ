﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    public class ТехСредство
    {
        protected string name;
        protected int price;

        public ТехСредство(string pName,int pPrice)
        {
            name = pName;
            price = pPrice;
        }
        virtual public string GetName()
        {
            return name;
        }
    }
}
