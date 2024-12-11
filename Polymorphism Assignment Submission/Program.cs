using System;

namespace InterfaceExample
{
    // Step 1: Define an interface called IQuittable
    public interface IQuittable
    {
        // Step 2: Define a method signature for Quit() in the interface
        void Quit();
    }

    // Step 3: Create an Employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        public string Name { get; set; } // Property for employee's name

        // Step 4: Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine($"{Name} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 5: Create an Employee object
            Employee employee1 = new Employee();
            employee1.Name = "John Doe"; // Assign the name to the employee

            // Step 6: Use polymorphism to create an IQuittable reference and assign it the Employee object
            IQuittable quitter = employee1;

            // Step 7: Call the Quit() method using the IQuittable reference
            quitter.Quit();  // This will call the Quit method implemented in the Employee class

            // Pause the console to view the output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

