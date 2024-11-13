global using ObjectOrientedProgrammingFinalProject;
using ObjectOrientedProgrammingFinalProject.CustomTypeFiles;
using System.Data;


Student simonHeilbuth = new Student("Simon", "Heilbuth", new DateTime(1985, 4, 16));
Student andreasLorentzen = new Student("Andreas", "Lorentsen", new DateTime(2007, 3, 3));
Student casperClemmensen = new Student("Casper", "Clemmensen", new DateTime(1986, 8, 15));
Student danielBjerrreJensen = new Student("Daniel Bjerre", "Jensen", new DateTime(2000, 4, 4));
Student hjalteMoesgaardLeth = new Student("Hjalte Moesgaard", "Leth", new DateTime(2000, 5, 5));
Student johanMilterJakobsen = new Student("Johan Milter", "Jakobsen", new DateTime(2005, 7, 4));
Student louisThomasDaoPetersen = new Student("Louis Thomas Dao", "Petersen", new DateTime(2006, 4, 1));
Student lukasHaugstadFrederiksen = new Student("Lukas Haugstad", "Frederiksen", new DateTime(2007, 5, 4));
Student marcusWahlstrom = new Student("Marcus", "Wahlstrøm", new DateTime(2000, 8, 4));
Student marcusSlotRohr = new Student("Marcus Slot", "Rohr", new DateTime(1996, 9, 9));
Student mathiasAltenburg = new Student("Mathias", "Altenburg", new DateTime(1997, 2, 2));
Student patrickGutierrezFogelstrom = new Student("Patrick Gutierrez", "Fogelstrøm", new DateTime(2003, 4, 4));
Student ramtinAkbari = new Student("Ramtin", "Akbari", new DateTime(1997, 2, 2));
Student sebastianTolbolNielsen = new Student("Sebastian Tølbøl", "Nielsen", new DateTime(1995, 1, 1));
Student tobiasSvarterHammarkvist = new Student("Tobias Svarter", "Hammarkvist", new DateTime(2007, 12, 13));
Student yosefKasas = new Student("Yosef", "Kasas", new DateTime(2000, 2, 2));
Student metteFrederiksen = new Student("Mette", "Frederiksen", new DateTime(1976, 4, 5));
Student larslokkeRasmussen = new Student("Lars Løkke", "Rasmussen", new DateTime(1964, 3, 2));
Student troelsLundPoulsen = new Student("Troels Lund", "Poulsen", new DateTime(1970, 8, 3));

Teacher nielsOlesen = new Teacher("Niels", "Olesen", new DateTime(1971, 1, 2));
Teacher henrikVincentsPoulsen = new Teacher("Henrik Vincent", "Poulsen", new DateTime(1978, 1, 2));
Teacher michaelGilbertHansen = new Teacher("Michael Gilber", "Hansen", new DateTime(1980, 9, 2));
Teacher nicolaiBoFredsoe = new Teacher("Nicolai Bo", "Fredsøe", new DateTime(1992, 10, 20));

List<Student> students = new List<Student> 
{
    simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, 
    johanMilterJakobsen, louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusWahlstrom,
    marcusSlotRohr, mathiasAltenburg, patrickGutierrezFogelstrom, ramtinAkbari, sebastianTolbolNielsen,
    tobiasSvarterHammarkvist, yosefKasas, metteFrederiksen, larslokkeRasmussen, troelsLundPoulsen
};

List<Teacher> teachers = new List<Teacher>
{
    nielsOlesen, henrikVincentsPoulsen, michaelGilbertHansen, nicolaiBoFredsoe
};

List<Subject> subjects = new List<Subject>
{
    new Subject{Name = "Grundæggende Programmering 2", Teacher = henrikVincentsPoulsen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas
        }, StartingDate = new DateTime(2024, 10, 21) },
    new Subject{Name = "Objectorienteret Programmering 2", Teacher = nielsOlesen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, ramtinAkbari
        }, StartingDate = new DateTime(2024, 11, 4) },
    new Subject{Name = "Computerteknologi 2", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        metteFrederiksen, larslokkeRasmussen, troelsLundPoulsen,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, ramtinAkbari
        }, StartingDate = new DateTime(2024, 11, 18) },
    new Subject{Name = "Grundæggende Programmering 2", Teacher = nicolaiBoFredsoe, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, larslokkeRasmussen,
        }, StartingDate = new DateTime(2024, 11, 25) },
    new Subject{Name = "Databaseprogrammering 3", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, metteFrederiksen
        }, StartingDate = new DateTime(2024, 12, 9) },
    new Subject{Name = "Databaseserver 2", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, troelsLundPoulsen
        }, StartingDate = new DateTime(2025, 1, 6) },
    new Subject{Name = "Clientsideprogrammering 2", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        metteFrederiksen, larslokkeRasmussen, troelsLundPoulsen
        }, StartingDate = new DateTime(2025, 1, 13) },
};
bool userWantsToQuit = false;
while (!userWantsToQuit)
{
    enmMainMenuChoice mainMenuChoice = StaticMethods.GetMainMenuChoice();

    if(mainMenuChoice == enmMainMenuChoice.SearchForSubject)
    {
        StaticMethods.PrintSubject(StaticMethods.GetSubjectChoice(subjects), true);
    }
    else if (mainMenuChoice == enmMainMenuChoice.SearchForTeacher)
    {
        StaticMethods.PrintTeacher(StaticMethods.GetTeacherChoice(teachers), subjects);
    }
    else if (mainMenuChoice == enmMainMenuChoice.SearchForStudent)
    {
        StaticMethods.PrintStudent(StaticMethods.GetStudentChoice(students), subjects);
    }
    else if (mainMenuChoice == enmMainMenuChoice.QuitProgram)
    {
        userWantsToQuit = true;
        Console.WriteLine("Farvel og tak fordi du brugte programmet");
        Console.ReadKey();
    }
}

