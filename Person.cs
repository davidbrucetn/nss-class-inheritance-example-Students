using System;

namespace StudentsAndInstructors
{

    public class Person
    {
        public string Name { get; set; }

        public int Cohort { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }

}