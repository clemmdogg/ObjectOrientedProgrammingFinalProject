using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject.CustomTypeFiles;

internal enum enmMainMenuChoice
{
    [Description("1) Søg på fag")]
    SearchForSubject = 1,
    [Description("2) Søg på lærer")]
    SearchForTeacher = 2,
    [Description("3) Søg på elev")]
    SearchForStudent = 3,
    [Description("4) Afslut programmet")]
    QuitProgram = 4
}
