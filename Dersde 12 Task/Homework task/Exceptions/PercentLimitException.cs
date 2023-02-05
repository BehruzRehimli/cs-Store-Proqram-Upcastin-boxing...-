using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_task.Exceptions
{
    internal class PercentLimitException:Exception
    {
        public PercentLimitException():base("\nIchkinin alkoqol faizi magaza uchun teyin edilmish limitden yuxari oldugundan bu ichkini magazanin mehsullari siyahisina daxil ede bilmerik.\n")
        {

        }
    }
}
