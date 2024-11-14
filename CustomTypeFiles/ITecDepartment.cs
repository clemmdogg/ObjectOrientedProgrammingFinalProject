using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal interface ITecDepartment
{
    public enmTecDepartments TecDepartment { get; set; }
    public void SetDepartment(enmTecDepartments tecDepartment);

    public int GetNumberOfEducations()
    {
        if (TecDepartment == enmTecDepartments.Frederiksberg) { return 30; }
        else if (TecDepartment == enmTecDepartments.Ballerup) { return 12; }
        else if (TecDepartment == enmTecDepartments.Odense) { return 1; }
        else { return 0; }
    }

}
