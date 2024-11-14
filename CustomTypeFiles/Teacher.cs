using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Teacher : Person, ITecDepartment
{
    public enmTecDepartments TecDepartment { get; set; }
    public Teacher(string firstName, String lastName, DateTime birthday) : base(firstName, lastName, birthday) { }
    public void SetDepartment(enmTecDepartments tecDeparment)
    {
        TecDepartment = tecDeparment;
    }
    public int GetNumberOfEducations()
    {
        ITecDepartment myInterface = this;
        return myInterface.IGetNumberOfEducations(TecDepartment);
    }
}
