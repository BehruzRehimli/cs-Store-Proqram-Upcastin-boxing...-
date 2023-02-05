using System;
using System.Collections.Generic;
using System.Text;
using Homework_task.Exceptions;


namespace Homework_task
{
    internal class Dairy : Product, IShowInfo
    {
        private byte _fatPercent;
        public byte FatPercent
        {
            get => _fatPercent;
            set 
            {
                if (value>=0&&value<=100)
                {
                    _fatPercent = value;
                }
                else
                {
                    throw new PercentException();
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"\nMehsul nomresi: {No}\nSud mehsulumuzun adi: {Name}\nSud mehsulumuzun qiymeti: {Price}\nSud mehsulumuzun yagliliq faizi: {FatPercent}");
        }
    }
}
