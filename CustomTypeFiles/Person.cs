using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Person : IDemographics
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }

    public Person(string firstName, string lastName, DateTime birthday)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthday = birthday;
    }
    public int GetAge()
    {
        IDemographics myInterface = this;
        return myInterface.IGetAge(Birthday);
    }
}
