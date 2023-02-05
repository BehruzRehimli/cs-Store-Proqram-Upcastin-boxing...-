using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task.Exceptions
{
    internal class PercentException:Exception
    {
        public PercentException():base("\nFaiz 0 ile 100 arasinda qeyd oluna biler.\n")
        {

        }
    }
}
