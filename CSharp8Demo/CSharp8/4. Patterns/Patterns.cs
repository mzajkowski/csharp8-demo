using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharp8.Patterns
{
    [Description("[4] Patterns")]
    class Patterns
    {
        static void Main(string[] args)
        {
            #region Tuple Pattern
            var p1 = new Person("Kim", "Sneum", "Madsen");
            var p2 = new Person("Marcin", "Zajkowski");

            WritePersonDetailsFor(p1);
            WritePersonDetailsFor(p2);
            #endregion
        }

        private static void WritePersonDetailsFor(Person p)
        {
            switch (p.FirstName, p.MiddleName, p.LastName)
            {
                case (string fn, string mn, string ln):
                    Console.WriteLine($"{fn} {mn} {ln}");
                    return;

                case (string fn, null, string ln):
                    Console.WriteLine($"{fn} {ln}");
                    return;

                case (string fn, null, null):
                    Console.WriteLine($"{fn}");
                    return;

                // etc...
            }

            #region Switch Expressions
            //var result = (p.FirstName, p.MiddleName, p.LastName) switch
            //{
            //    (string fn, string mn, string ln) => $"{fn} {mn} {ln}",
            //    (string fn, null, string ln) => $"{fn} {ln}",
            //    (string fn, null, null) => $"{fn}"
            //};

            //Console.WriteLine(result);
            #endregion
        }
    }
}
