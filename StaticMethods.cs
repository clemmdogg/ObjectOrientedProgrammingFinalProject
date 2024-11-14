using ObjectOrientedProgrammingFinalProject.CustomTypeFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject;

internal static class StaticMethods
{
    /// 
    /// METODES I WOULD LIKE TO BREAK THE CONSOLE-PROGRAM.CS CONVENTION WITH!!!
    ///

    /// <summary>
    /// Creates the main menu and returns the choice
    /// </summary>
    /// <returns>Enum choice</returns>
    public static enmMainMenuChoice GetMainMenuChoice()
    {
        while (true)
        {
            Console.WriteLine("Vælg:");
            Console.WriteLine("1) Søg på fag");
            Console.WriteLine("2) Søg på lærer");
            Console.WriteLine("3) Søg på elev");
            Console.WriteLine("4) Afslut programmet");
            Console.Write("Vælg et tal for en af de ovenstående muligheder: ");
            string userInput = Console.ReadLine();
            if (userInput == "1") { return enmMainMenuChoice.SearchForSubject; }
            else if (userInput == "2") { return enmMainMenuChoice.SearchForTeacher; }
            else if (userInput == "3") { return enmMainMenuChoice.SearchForStudent; }
            else if (userInput == "4") { return enmMainMenuChoice.QuitProgram; }
            else
            {
                NoMatchFound();
            }

        }
    }
    /// <summary>
    /// Creates a menu from list of subjects, that  makes the user choose a subject and returns that subject.
    /// </summary>
    /// <param name="subjects">List of subjects the user can pick from</param>
    /// <returns>The userpicked subject</returns>
    public static Subject GetSubjectChoice(List<Subject> subjects)
    {
        subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
        while (true)
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
                return subjects[input - 1];
            }
            else
            {
                NoMatchFound();
            }
        }
    }
    /// <summary>
    /// Creates a menu from list of teachers, that  makes the user choose a subject and returns that teacher.
    /// </summary>
    /// <param name="teachers">List of teachers the user can pick from</param>
    /// <returns>The userpicked teacher</returns>
    public static Teacher GetTeacherChoice(List<Teacher> teachers)
    {
        teachers = teachers.OrderBy(teachers => teachers.FirstName).ToList();
        while (true)
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
                return teachers[input - 1];
            }
            else
            {
                NoMatchFound();
            }
        }
    }
    /// <summary>
    /// The user can input the name from a student to get that student obejct.
    /// </summary>
    /// <param name="students">List of students the user can pick from</param>
    /// <returns>The userpicked student or a string if user wants to quit</returns>
    public static dynamic GetStudentChoice(List<Student> students)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Indtast navnet på den elev, du vil søge på eller [A] for afslut: ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "a")
            {
                return "User don't want to search!";
            }
            foreach (Student student in students)
            {
                if ($"{student.FirstName.ToLower()} {student.LastName.ToLower()}" == userInput)
                {
                    return student;
                }
            }
            NoMatchFound();
        }
    }
    /// <summary>
    /// Prints out the subject object according to the exercise.
    /// </summary>
    /// <param name="subject">The subject object that is going to be printed</param>
    /// <param name="withTeacherName">Is the teacher name also going to be printed?</param>
    public static void PrintSubject(Subject subject, bool withTeacherName)
    {
        Console.WriteLine($"\tFag: {subject.Name}");
        if (withTeacherName)
        {
            Console.WriteLine($"\tLærer: {subject.Teacher.FirstName} {subject.Teacher.LastName}");
        }
        Console.WriteLine($"\tAntal elever ialt: {subject.Students.Count}");
        foreach (Student student in subject.Students)
        {
            DateCalculator dateCalculator = new DateCalculator(student.Birthday);
            if (dateCalculator.IsDateLessThan20YearsAgo())
            {
                WriteLineGreen($"\t\t{student.FirstName} {student.LastName}");
            }
            else { Console.WriteLine($"\t\t{student.FirstName} {student.LastName}"); }
        }
    }
    /// <summary>
    /// Prints out the teacher object according to the exercise.
    /// </summary>
    /// <param name="teacher">The teacher object that is going to be printed</param>
    /// <param name="subjects">The subjects you want to search through with teacher object</param>
    public static void PrintTeacher(Teacher teacher, List<Subject> subjects)
    {
        subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
        List<Subject> filteredSubject = 
            subjects.Where(
                (subject => subject.Teacher.FirstName == teacher.FirstName && 
                subject.Teacher.LastName == teacher.LastName)
                ).ToList();
        foreach (Subject subject in filteredSubject)
        {
            PrintSubject(subject, false);
        }
    }
    /// <summary>
    /// Prints out the student object according to the exercise.
    /// </summary>
    /// <param name="student">The student object that is going to be printed</param>
    /// <param name="subjects">The subjects you want to search through with student object</param>
    public static void PrintStudent(Student student, List<Subject> subjects)
    {
        foreach (Subject subject in subjects)
        {
            if (subject.Students.Contains(student))
            {
                Console.WriteLine($"\tFag: {subject.Name}");
                Console.WriteLine($"\tLærerens navn: {subject.Teacher.FirstName} {subject.Teacher.LastName}");
                Console.WriteLine();
            }
        }
    }
    /// <summary>
    /// Quits the searching for a student menu
    /// </summary>
    /// <param name="quittingString">The string that gets to this method</param>
    /// <param name="subjects">Only a parameter used if printing a student</param>
    public static void PrintStudent(string quittingString, List<Subject> subjects)
    {
        Console.Clear();
        return;
    }
    /// <summary>
    /// Printing "Ingen match fundet!!" in red foreground, and makes ReadKey()
    /// </summary>
    public static void NoMatchFound()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingen match fundet!!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ReadKey();
        Console.Clear();
    }
    /// <summary>
    /// Writes a line in green font
    /// </summary>
    /// <param name="text">The text that needs to be green</param>
    public static void WriteLineGreen(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
