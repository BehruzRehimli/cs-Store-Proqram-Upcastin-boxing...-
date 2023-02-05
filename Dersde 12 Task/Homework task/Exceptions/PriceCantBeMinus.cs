using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task.Exceptions
{
    internal class PriceCantBeMinus:Exception
    {
        public PriceCantBeMinus() : base("\nQiymet menfi ola bilmez.\n") 
        {

        }
    }
}
