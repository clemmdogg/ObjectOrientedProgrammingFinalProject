using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Teacher : Person
{
    public Teacher(string firstName, string lastName, DateTime birthday) : base(firstName, lastName, birthday) { }
}
