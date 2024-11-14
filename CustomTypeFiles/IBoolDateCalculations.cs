using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal interface IBoolDateCalculations
{
    public bool IIsDateLessThan20YearsAgo(DateTime date)
    {
        return (date.AddYears(20) >= DateTime.Now);
    }
}
