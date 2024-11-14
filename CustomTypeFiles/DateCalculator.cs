using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

public struct DateCalculator
{
    public DateTime Date {  get; set; }
    public DateCalculator(DateTime date)
    {
        Date = date;
    }
    public bool IsDateLessThan20YearsAgo()
    {
        return (Date.AddYears(20) >= DateTime.Now); ;
    }
}
