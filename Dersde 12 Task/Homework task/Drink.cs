using System;
using System.Collections.Generic;
using System.Text;
using Homework_task.Exceptions;


namespace Homework_task
{
    internal class Drink:Product,IShowInfo
    {
        private byte _alcoholPercent;
        public byte AlcoholPercent { get { return _alcoholPercent; }
            set 
            {
                if (value>=0&&value<=100)
                {
                    _alcoholPercent = value;
                }
                else
                {
                    throw new PercentException();
                }
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"\nMehsul nomresi: {No}\nIchkimizin adi: {Name}\nIchkimizin qiymeti: {Price}\nIchkimizin alkaqol faizi: {AlcoholPercent}");
        }
    }
}
