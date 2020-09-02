using System;

namespace StudentsAndInstructors
{

    public class Student : Person
    {
        public bool IsThirsty { get; set; }
        public string FavoriteLanguage { get; set; }

        public void Learn(string lesson)
        {
            Console.WriteLine($"{Name} has learned {lesson}.");
        }

        public void AskQuestion()
        {
            Console.WriteLine("But, why???");
        }
    }

}