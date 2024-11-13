using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

public struct DateCalculator
{
    public DateTime Date;

    public DateCalculator(DateTime date)
    {
        Date = date;
    }
    public bool IsDateMoreThan20YearsAgo()
    {
        return (Date.AddYears(20) >= DateTime.Now);
    }
}
