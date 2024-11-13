using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal class Subject
{
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
    public DateTime StartingDate { get; set; }
}