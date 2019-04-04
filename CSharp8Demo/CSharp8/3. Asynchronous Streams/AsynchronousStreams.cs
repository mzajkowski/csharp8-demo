using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8.AsynchronousStreams
{
    [Description("[3] Asynchronous Streams")]
    class AsynchronousStreams
    {
        static void Main(string[] args)
        {
            var followers = SocialMediaService.GetFollowers();
            var handles = GetHandlesFor(followers);

            foreach (var handle in handles)
            {
                Console.WriteLine($"@{handle} has just followed you!");
            }
        }

        private static IEnumerable<string> GetHandlesFor(IEnumerable<Person> followers)
        {
            foreach (var p in followers)
            {
                yield return GetHandle(p);
            }
        }

        private static async IAsyncEnumerable<string> GetHandlesFor(IAsyncEnumerable<Person> followers)
        {
            await foreach (var p in followers)
            {
                yield return GetHandle(p);
            }
        }

        private static string GetHandle(Person p)
        {
            return p.FirstName.ToLower();
        }
    }

    internal class SocialMediaService
    {
        internal static IEnumerable<Person> GetFollowers()
        {
            Person[] peopleArray =
            {
                new Person("Anthony", "Dang"),
                new Person("Ismail", "Mayat"),
                new Person("Marcin", "Zajkowski")
            };

            foreach (var p in peopleArray)
            {
                yield return p;
            }
        }

        internal static async IAsyncEnumerable<Person> GetFollowersAsync()
        {
            Person[] peopleArray =
            {
                new Person("Anthony", "Dang"),
                new Person("Ismail", "Mayat"),
                new Person("Marcin", "Zajkowski")
            };

            foreach (var p in peopleArray)
            {
                var random = new Random();
                var randomDelay = random.Next(1000, 5000);

                await Task.Delay(randomDelay);

                yield return p;
            }
        }
    }
}
