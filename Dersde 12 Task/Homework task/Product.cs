using Homework_task.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task
{
    internal abstract class Product
    {
        public Product()
        {
            Count++;
            No = Count;
        }
        public readonly int No;
        static int Count;
        public string Name;
        private double _price;
        public double Price {get=> _price;
            set
            {
                if (value>0)
                {
                    _price = value;
                }
                else
                {
                    throw new PriceCantBeMinus();
                }
            }
        }
        public abstract void ShowInfo();
    }
}
