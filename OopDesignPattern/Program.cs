using System;

namespace OopsDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------STUDENTS---------");
            int n = GetNumberOfEntities("students");
            Student[] students = GetStudentDetails(n);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("--------TEACHERS---------");
            int n1 = GetNumberOfEntities("teachers");
            Teacher[] teachers = GetTeacherDetails(n1);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("--------SUBJECTS---------");
            int n2 = GetNumberOfEntities("subjects");
            Subject[] subjects = GetSubjectDetails(n2);

            PrintDetails("STUDENTS", students);
            PrintDetails("TEACHERS", teachers);
            PrintDetails("SUBJECTS", subjects);
        }

        static int GetNumberOfEntities(string entityType)
        {
            Console.WriteLine($"Enter the number of {entityType} to record:");
            return int.Parse(Console.ReadLine());
        }

        static Student[] GetStudentDetails(int n)
        {
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter student name {i}");
                string name = Console.ReadLine();
                Console.WriteLine("Enter class");
                int cls = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter section");
                char section = char.Parse(Console.ReadLine());
                students[i] = new Student(name, cls, section);
                Console.WriteLine("---------------");
            }
            return students;
        }

        static Teacher[] GetTeacherDetails(int n)
        {
            Teacher[] teachers = new Teacher[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter teacher name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter subject name");
                string subject = Console.ReadLine();
                teachers[i] = new Teacher(name, subject);
                Console.WriteLine("---------------");
            }
            return teachers;
        }

        static Subject[] GetSubjectDetails(int n)
        {
            Subject[] subjects = new Subject[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter subject name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter subject code");
                string code = Console.ReadLine();
                subjects[i] = new Subject(name, code);
                Console.WriteLine("---------------");
            }
            return subjects;
        }

        static void PrintDetails<T>(string entityType, T[] entities) where T : IEntityWithName
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"----------PRINTING DETAILS OF {entityType}------------");
            foreach (var item in entities)
            {
                Console.WriteLine($"Name: {item.Name}");
                if (item is Student)
                {
                    Console.WriteLine($"Class: {((Student)(object)item).Class}");
                    Console.WriteLine($"Section: {((Student)(object)item).Section}");
                }
                else if (item is Teacher)
                {
                    Console.WriteLine($"Subject: {((Teacher)(object)item).Subject}");
                }
                else if (item is Subject)
                {
                    Console.WriteLine($"Subject Code: {((Subject)(object)item).SubCode}");
                }
                Console.WriteLine("---------------");
            }
        }
    }

    public interface IEntityWithName
    {
        string Name { get; }
    }
}
