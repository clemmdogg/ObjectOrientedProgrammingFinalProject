global using ObjectOrientedProgrammingFinalProject;
using ObjectOrientedProgrammingFinalProject.CustomTypeFiles;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
// Initilizing all students
Student simonHeilbuth = new ("Simon", "Heilbuth", new DateTime(1985, 4, 16));
Student andreasLorentzen = new ("Andreas", "Lorentsen", new DateTime(2007, 3, 3));
Student casperClemmensen = new ("Casper", "Clemmensen", new DateTime(1986, 8, 15));
Student danielBjerrreJensen = new ("Daniel Bjerre", "Jensen", new DateTime(2000, 4, 4));
Student hjalteMoesgaardLeth = new ("Hjalte Moesgaard", "Leth", new DateTime(2000, 5, 5));
Student johanMilterJakobsen = new ("Johan Milter", "Jakobsen", new DateTime(2005, 7, 4));
Student louisThomasDaoPetersen = new ("Louis Thomas Dao", "Petersen", new DateTime(2006, 4, 1));
Student lukasHaugstadFrederiksen = new ("Lukas Haugstad", "Frederiksen", new DateTime(2007, 5, 4));
Student marcusWahlstrom = new ("Marcus", "Wahlstrøm", new DateTime(2000, 8, 4));
Student marcusSlotRohr = new ("Marcus Slot", "Rohr", new DateTime(1996, 9, 9));
Student mathiasAltenburg = new ("Mathias", "Altenburg", new DateTime(1997, 2, 2));
Student patrickGutierrezFogelstrom = new ("Patrick Gutierrez", "Fogelstrøm", new DateTime(2003, 4, 4));
Student ramtinAkbari = new ("Ramtin", "Akbari", new DateTime(1997, 2, 2));
Student sebastianTolbolNielsen = new ("Sebastian Tølbøl", "Nielsen", new DateTime(1995, 1, 1));
Student tobiasSvarterHammarkvist = new ("Tobias Svarter", "Hammarkvist", new DateTime(2007, 12, 13));
Student yosefKasas = new ("Yosef", "Kasas", new DateTime(2000, 2, 2));
Student metteFrederiksen = new ("Mette", "Frederiksen", new DateTime(1976, 4, 5));
Student larslokkeRasmussen = new ("Lars Løkke", "Rasmussen", new DateTime(1964, 3, 2));
Student troelsLundPoulsen = new ("Troels Lund", "Poulsen", new DateTime(1970, 8, 3));

// Initilizing all teachers
Teacher nielsOlesen = new ("Niels", "Olesen", new DateTime(1971, 1, 2));
Teacher henrikVincentsPoulsen = new ("Henrik Vincent", "Poulsen", new DateTime(1978, 1, 2));
Teacher michaelGilbertHansen = new ("Michael Gilbert", "Hansen", new DateTime(1980, 9, 2));
Teacher nicolaiBoFredsoe = new ("Nicolai Bo", "Fredsøe", new DateTime(1992, 10, 20));

// Defining a list with all students
List<Student> students = new List<Student> 
{
    simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, 
    johanMilterJakobsen, louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusWahlstrom,
    marcusSlotRohr, mathiasAltenburg, patrickGutierrezFogelstrom, ramtinAkbari, sebastianTolbolNielsen,
    tobiasSvarterHammarkvist, yosefKasas, metteFrederiksen, larslokkeRasmussen, troelsLundPoulsen
};

// Defining a list with all teachers
List<Teacher> teachers = new List<Teacher>
{
    nielsOlesen, henrikVincentsPoulsen, michaelGilbertHansen, nicolaiBoFredsoe
};

// Initilizing all subjects
List<Subject> subjects = new List<Subject>
{
    new Subject{Name = "Databaseprogrammering 3", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, metteFrederiksen
        }, StartingDate = new DateTime(2024, 12, 9) },
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
    new Subject{Name = "Grundæggende Programmering 2", Teacher = henrikVincentsPoulsen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas
        }, StartingDate = new DateTime(2024, 10, 21) },
    new Subject{Name = "Server og Sikkerhed 2", Teacher = nicolaiBoFredsoe, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, larslokkeRasmussen,
        }, StartingDate = new DateTime(2024, 11, 25) },
    new Subject{Name = "Databaseserver 2", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        simonHeilbuth, andreasLorentzen, casperClemmensen, danielBjerrreJensen, hjalteMoesgaardLeth, johanMilterJakobsen,
        louisThomasDaoPetersen, lukasHaugstadFrederiksen, marcusSlotRohr, marcusWahlstrom, mathiasAltenburg,
        patrickGutierrezFogelstrom, sebastianTolbolNielsen, tobiasSvarterHammarkvist, yosefKasas, troelsLundPoulsen
        }, StartingDate = new DateTime(2025, 1, 6) },
    new Subject{Name = "Clientsideprogrammering 2", Teacher = michaelGilbertHansen, Students = new List<Student>(){
        metteFrederiksen, larslokkeRasmussen, troelsLundPoulsen
        }, StartingDate = new DateTime(2025, 1, 13) },
};

bool isUserWantingToQuit = false;
while (!isUserWantingToQuit)
{
    // Main menu
    enmMainMenuChoice mainMenuChoice = StaticMethods.GetMainMenuChoice();
    // Choices of main menu
    if (mainMenuChoice == enmMainMenuChoice.SearchForSubject)
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
        isUserWantingToQuit = true;
        Console.WriteLine("Farvel og tak fordi du brugte programmet");
        Console.ReadKey();
    }
    else
    {
        StaticMethods.NoMatchFound();
    }
}

/*
///
/// RUNNING PROGRAM WITHOUT STATIC METHODS
///

// Main menu
bool userWantsToQuit = false;
while (!userWantsToQuit)
{
    enmMainMenuChoice mainMenuChoice = enmMainMenuChoice.QuitProgram;
    bool isInputCorrectInMainMenu = false;
    while (!isInputCorrectInMainMenu)
    {
        Console.WriteLine("Vælg:");
        Console.WriteLine("1) Søg på fag");
        Console.WriteLine("2) Søg på lærer");
        Console.WriteLine("3) Søg på elev");
        Console.WriteLine("4) Afslut programmet");
        Console.Write("Vælg et tal for en af de ovenstående muligheder: ");
        string userInput = Console.ReadLine();
        if (userInput == "1")
        {
            mainMenuChoice = enmMainMenuChoice.SearchForSubject;
            isInputCorrectInMainMenu = true;
        }
        else if (userInput == "2")
        {
            mainMenuChoice = enmMainMenuChoice.SearchForTeacher;
            isInputCorrectInMainMenu = true;
        }
        else if (userInput == "3")
        {
            mainMenuChoice = enmMainMenuChoice.SearchForStudent;
            isInputCorrectInMainMenu = true;
        }
        else if (userInput == "4")
        {
            mainMenuChoice = enmMainMenuChoice.QuitProgram;
            isInputCorrectInMainMenu = true;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingen match fundet!!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
        }

    }
    // Choices of main menu
    if (mainMenuChoice == enmMainMenuChoice.SearchForSubject)
    {
        // Gets the correct subject
        subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
        Subject usersSubjectChoice = new Subject();
        bool isInputCorrectInSubjectMenu = false;

        while (!isInputCorrectInSubjectMenu)
        {
            Console.Clear();
            int subjectIndex = 0;
            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"{subjectIndex + 1}) {subject.Name}");
                subjectIndex++;
            }
            Console.Write("Vælg et tal for en af de ovenstående fag: ");
            if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= subjects.Count)
            {
                usersSubjectChoice = subjects[input - 1];
                isInputCorrectInSubjectMenu = true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen match fundet!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Prints the subject
        Console.WriteLine($"\tFag: {usersSubjectChoice.Name}");
        Console.WriteLine($"\tLærer: {usersSubjectChoice.Teacher.FirstName} {usersSubjectChoice.Teacher.LastName}");
        Console.WriteLine($"\tAntal elever ialt: {usersSubjectChoice.Students.Count}");
        foreach (Student student in usersSubjectChoice.Students)
        {
            DateCalculator dateCalculator = new DateCalculator(student.Birthday);
            if (dateCalculator.IsDateLessThan20YearsAgo())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t{student.FirstName} {student.LastName}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else { Console.WriteLine($"\t\t{student.FirstName} {student.LastName}"); }
        }
    }

    else if (mainMenuChoice == enmMainMenuChoice.SearchForTeacher)
    {
        // Gets the correct teacher
        teachers = teachers.OrderBy(teachers => teachers.FirstName).ToList();
        Teacher usersTeacherChoice = new Teacher("", "", new DateTime());
        bool isInputCorrectInTeacherMenu = false;

        while (!isInputCorrectInTeacherMenu)
        {
            Console.Clear();
            int teacherIndex = 0;
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"{teacherIndex + 1}) {teacher.FirstName} {teacher.LastName}");
                teacherIndex++;
            }
            Console.Write("Vælg et tal for en af de ovenstående fag: ");
            if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= teachers.Count)
            {
                usersTeacherChoice = teachers[input - 1];
                isInputCorrectInTeacherMenu = true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen match fundet!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Prints the correct teacher
        subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
        List<Subject> filteredSubject =
            subjects.Where(
                (subject => subject.Teacher.FirstName == usersTeacherChoice.FirstName &&
                subject.Teacher.LastName == usersTeacherChoice.LastName)
                ).ToList();
        foreach (Subject subject in filteredSubject)
        {
            Console.WriteLine($"\tFag: {subject.Name}");
            Console.WriteLine($"\tAntal elever ialt: {subject.Students.Count}");
            foreach (Student student in subject.Students)
            {
                DateCalculator dateCalculator = new DateCalculator(student.Birthday);
                if (dateCalculator.IsDateLessThan20YearsAgo())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\t\t{student.FirstName} {student.LastName}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else { Console.WriteLine($"\t\t{student.FirstName} {student.LastName}"); }
            }
        }
    }
    else if (mainMenuChoice == enmMainMenuChoice.SearchForStudent)
    {
        // Gets the correct student
        Student usersStudentChoice = new Student("", "", new DateTime());
        bool isInputCorrectInStudentMenu = false;
        while (!isInputCorrectInStudentMenu)
        {
            Console.Clear();
            Console.Write("Indtast navnet på den elev, du vil søge på eller [A] for afslut: ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == null || userInput.Length == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen match fundet!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            if (userInput == "a")
            {
                Console.Clear();
                isInputCorrectInStudentMenu = true;
            }
            foreach (Student student in students)
            {
                if ($"{student.FirstName.ToLower()} {student.LastName.ToLower()}" == userInput)
                {
                    usersStudentChoice = student;
                    isInputCorrectInStudentMenu = true;
                }
            }
            if (!isInputCorrectInStudentMenu)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingen match fundet!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Prints the student
        if (!(usersStudentChoice.FirstName.Length == 0 && usersStudentChoice.LastName.Length == 0))
        {
            subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
            foreach (Subject subject in subjects)
            {
                if (subject.Students.Contains(usersStudentChoice))
                {
                    Console.WriteLine($"\tFag: {subject.Name}");
                    Console.WriteLine($"\tLærerens navn: {subject.Teacher.FirstName} {subject.Teacher.LastName}");
                    Console.WriteLine();
                }
            }
        }
    }
    else if (mainMenuChoice == enmMainMenuChoice.QuitProgram)
    {
        // Quitting the program 
        userWantsToQuit = true;
        Console.WriteLine("Farvel og tak fordi du brugte programmet");
        Console.ReadKey();
    }
}
*/
