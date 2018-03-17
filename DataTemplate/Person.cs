using System.Collections.Generic;

namespace DataTemplate
{
    internal class Person
    {
        public Person(string firstName, string lastName, int age, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            Position = position;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }

    internal class PersonList : List<Person>
    {
        public PersonList()
        {
            Add(new Person("John", "Doe", 23, "Developer"));
            Add(new Person("Kent", "Elgas", 29, "Tester"));
            Add(new Person("Rea", "Ostrom", 31, "Team Lead"));
            Add(new Person("Lupe", "Campen", 42, "Project Manager"));
            Add(new Person("Alexander", "Heys", 35, "Developer"));
        }
    }
}