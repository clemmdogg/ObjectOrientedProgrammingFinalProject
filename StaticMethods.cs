using ObjectOrientedProgrammingFinalProject.CustomTypeFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFinalProject;

internal static class StaticMethods
{
    /*
     /// 
     /// METODES I WOULD LIKE TO BREAK THE CONSOLE-PROGRAM.CS CONVENTION WITH!!!
     ///

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
    public static Student GetStudentChoice(List<Student> students)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Indtast navnet på den elev, du vil søge på eller [A] for afslut: ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "a")
            {
                return new Student("Michael", "Laudrup", new DateTime(1962, 5, 5));
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
            if (student.Birthday.AddYears(20) > DateTime.Now)
            {
                WriteLineGreen($"\t\t{student.FirstName} {student.LastName}");
            }
            else { Console.WriteLine($"\t\t{student.FirstName} {student.LastName}"); }
        }
    }
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
    public static void PrintStudent(Student student, List<Subject> subjects)
    {
        subjects = subjects.OrderBy(subjects => subjects.StartingDate).ToList();
        if (student.FirstName == "Michael" && student.LastName == "Laudrup")
        {
            Console.Clear();
            return;
        }
        foreach (Subject subject in subjects)
        {
            if (subject.Students.Contains(student))
            {
                Console.WriteLine($"\tFag: {subject.Name}");
                Console.WriteLine($"\tLærerens navn: {subject.Teacher}");
                Console.WriteLine();
            }
        }
    }
    
    public static void NoMatchFound()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingen match fundet!!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ReadKey();
        Console.Clear();
    }
    public static void WriteLineGreen(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    */
}
