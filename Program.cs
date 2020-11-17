using System;
using System.Collections.Generic;


namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public List<Employee> Employees = new List<Employee>();
        public Company(string name, DateTime created)
        {
            Name = name;
            CreatedOn = created;
        }
    }
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        public Employee(string first, string last, string title, DateTime start)
        {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = start;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
                
            */
            Company store = new Company("What A Time To Buy Things", DateTime.Now);

            Employee Robert = new Employee("Robert", "Jackman", "Cashier", DateTime.Now);
            Employee Julie = new Employee("Julie", "Adams", "Janitor", DateTime.Now);
            Employee Mike = new Employee("Mike", "Michaelson", "Manager", DateTime.Now);

            store.Employees.Add(Robert);
            store.Employees.Add(Julie);
            store.Employees.Add(Mike);

            foreach (Employee employee in store.Employees)
            {
                Console.WriteLine($@"
            {employee.FirstName} {employee.LastName}
            Title: {employee.Title}
            Date Started: {employee.StartDate}
            ");
            }
        }
    }
}