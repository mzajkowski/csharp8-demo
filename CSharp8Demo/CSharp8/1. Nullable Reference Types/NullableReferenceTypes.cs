#nullable disable

using System;
using System.ComponentModel;

namespace CSharp8
{
    [Description("[1] Nullable Reference Types")]
    class NullableReferenceTypes
    {
        static void Main()
        {
            var kim = new Person("Kim", "Sneum", "Madsen");
            var maiken = new Person("Maiken", "Skov", "Nielsen");

            // The fun begins here... :>
            var me = new Person("Marcin", null, "Zajkowski");
            var niels = new Person("Niels", null, "Hartvig");

            PrintNameLengthsFor(kim);
            PrintNameLengthsFor(maiken);
            PrintNameLengthsFor(me);
            PrintNameLengthsFor(niels);
        }

        static void PrintNameLengthsFor(Person person)
        {
            string first = person.FirstName;
            string middle = person.MiddleName;
            string last = person.LastName;

            Console.WriteLine("First={0}; Last={1}; Middle={2}",
                first.Length,
                last.Length,
                middle.Length);
        }
    }

    class Person
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            //MiddleName = null;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
    }
}
