using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

public struct DateCalculator : IBoolDateCalculations
{
    public DateTime Date;

    public DateCalculator(DateTime date)
    {
        Date = date;
    }
    public bool IsDateLessThan20YearsAgo()
    {
        IBoolDateCalculations myInterface = this;
        return myInterface.IIsDateLessThan20YearsAgo(Date);
    }
}
