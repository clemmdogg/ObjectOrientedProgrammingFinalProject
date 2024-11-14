using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

public struct DateCalculator
{
    public bool IsDateLessThan20YearsAgo(DateTime date)
    {
        return (date.AddYears(20) >= DateTime.Now); ;
    }
}
