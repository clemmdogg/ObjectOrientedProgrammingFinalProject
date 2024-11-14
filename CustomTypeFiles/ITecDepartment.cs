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

    public int IGetNumberOfEducations(enmTecDepartments TecDepartment)
    {
        if (TecDepartment == enmTecDepartments.Frederiksberg) { return 30; }
        if (TecDepartment == enmTecDepartments.Ballerup) { return 12; }
        if (TecDepartment == enmTecDepartments.Odense) { return 1; }
        else { return 0; }
        
    }

}
