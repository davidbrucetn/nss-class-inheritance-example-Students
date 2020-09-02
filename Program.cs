using System;

namespace StudentsAndInstructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Student bob = new Student();
            bob.Name = "Bob";
            bob.Cohort = 99;
            bob.IsThirsty = true;
            bob.FavoriteLanguage = "C#";
            // bob.Greet();
            bob.Learn("Inheritance");
            bob.AskQuestion();

            Console.WriteLine("----------------------------");
            Instructor mary = new Instructor();
            mary.Name = "Mary";
            mary.Cohort = 99;
            mary.Specialty = "LINQ";
            mary.MonthsOfExperience = 60;
            // mary.Greet();
            mary.Teach("Variables");

            Console.WriteLine("----------Say Hello-------------");

            SayHello(mary);
            SayHello(bob);
        }

        static void SayHello(Person aPerson)
        {
            // Can only use properties and methods of Person base/parent class
            aPerson.Greet();
        }
    }
}