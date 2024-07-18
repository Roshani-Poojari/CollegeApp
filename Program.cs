using CollegeApp.Models;

namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(103, "Andheri", new DateOnly(1995,03,21));
            Student student = new Student(56, "Powai", new DateOnly(1999, 08, 3),"Science");
            Professor professor = new Professor(210, "Vikhroli", new DateOnly(1968, 11, 17),65000);
            PrintPersonType(person);
            PrintPersonType(professor);
            PrintPersonType(student);
        }
        static void PrintPersonType(Person person) 
        {
            Console.WriteLine($"<---------------{person.GetType().Name}--------------->");
            Console.WriteLine(person.PrintDetails());
        }
    }
}
