using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task.Exceptions
{
    internal class DairyProductLimitBroken:Exception
    {
        public DairyProductLimitBroken() : base("\nMagazada teyin olunmush limit qeder sud mehsulu elave oluna biler. Hal hazirdateyin olunmush limit qeder sud mehsulu var.\n")
        {

        }
    }
}
