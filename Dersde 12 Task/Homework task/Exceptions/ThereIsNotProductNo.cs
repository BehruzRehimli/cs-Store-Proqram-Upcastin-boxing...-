using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task.Exceptions
{
    internal class ThereIsNotProductNo:Exception
    {
        public ThereIsNotProductNo():base("\nBu nomreli mehsul hal hazirda magazamizda movcud deyil.\n")
        {

        }
    }
}
