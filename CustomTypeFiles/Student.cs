using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Student : Person
{
    public Student(string firstName, string lastName, DateTime birthday) : base(firstName, lastName, birthday) { }
}
