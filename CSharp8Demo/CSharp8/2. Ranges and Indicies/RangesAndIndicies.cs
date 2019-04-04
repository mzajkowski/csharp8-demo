using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharp8.RangesAndIndicies
{
    [Description("[2] Ranges and Indicies")]
    class RangesAndIndicies
    {
        static void Main(string[] args)
        {
            #region Names
            var names = GetNames();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region Separator
            Console.WriteLine("---");
            #endregion

            #region People
            var team = GetPeople();

            foreach (var member in team)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName}");
            }
            #endregion
        }

        static IEnumerable<string> GetNames()
        {
            string[] names =
            {
                "Anthony",
                "Arek",
                "Greg",
                "Grzegorz",
                "Imran",
                "Ismail",
                "Łukasz",
                "Marcin",
                "Wojciech"
            };

            foreach (var name in names)
            {
                yield return name;
            }
        }

        static IEnumerable<Person> GetPeople()
        {
            Person[] peopleArray =
            {
                new Person("Anthony", "Dang"),
                new Person("Ismail", "Mayat"),
                new Person("Marcin", "Zajkowski")
            };

            #region Ranges and Indexes
            //peopleArray = peopleArray[0..2];

            //Range range = 1..3;
            //peopleArray = peopleArray[range];

            /*
             * 
             * From Mads Torgensen:
             * Range expressions can be open at either or both ends. ..^1 means the same as 0..^1. 1.. means the same as 1..^0. 
             * And .. means the same as 0..^0: beginning to end. Try them all out and see! 
             * Try mixing and matching “from beginning” and “from end” Indexes at either end of a Range and see what happens.
             * 
             */
            //peopleArray = peopleArray[0..^1];
            #endregion

            foreach (var p in peopleArray)
            {
                yield return p;
            }
        }
    }
}
