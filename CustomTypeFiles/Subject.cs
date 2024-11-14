using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Subject : ITecDepartment
{
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
    public DateTime StartingDate { get; set; }
    public enmTecDepartments TecDepartment { get; set; }

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