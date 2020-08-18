using System;
using System.Collections.Generic;
using System.Threading;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var students = new List<string>();
            var instructors = new List<string>();
            var evening11 = new List<string>();
            var numbers = new List<int>();

            names.Add("Jameka");
            names.Add("Nathan");
            names.Add("John");

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            students.Add("Aaron");
            students.Add("John");
            students.Add("Monique");

            //add multiple at once from an existing list
            evening11.AddRange(instructors);
            evening11.AddRange(students);

            foreach (var person in evening11)
            {
                Console.WriteLine($"{person} is in evening 11.");
            }

            //is the item in the list?
            var steveIsInE11 = evening11.Contains("Steve");

            //ternary inside interpolated strings have to be in parentheses
            Console.WriteLine($"Steve is {(steveIsInE11 ? "" : "not")}");

            //just the first match
            var matchingPerson = evening11.Find(person => person.StartsWith("J"));

            Console.WriteLine($"{matchingPerson} starts with 'J'");

            //in a list, the index is the key
            Console.WriteLine($"{students[1]} is the sstudent at th index of 1");

            //dictionaries have 2 generic type parameters
            var words = new Dictionary<string, string>();

            // dictionary entries are made of key value pairs, and both must be supplied to add anything
            words.Add("pedantic", "Like a pendant");
            words.Add("congratulate", "to be exctied for; celebrate");
            words.Add("scrupulous", "dillident, through, extremely attentive to details");

            //key myust be unique this won't work
            //words.Add("congratulate", "not a real thing");

            Console.WriteLine($"The fake definition of Congratulation is {words["congratulate"]}");

            //foreach (var entry in words)
            //{
            //    Console.WriteLine($"The fake definition of {entry.Key} is {entry.Value}");
            //}

            //deconstructed
            foreach (var (word,definition) in words)
            {
                Console.WriteLine($"The fake defintion of {word} is {definition}");
            }

            var wordsWithMultipleDefinitions = new Dictionary<string, List<string>>();

            wordsWithMultipleDefinitions.Add("Scrupulous", new List<string>()
            {
                "Dilligent",
                "Thorough",
                "Extremely attentive to detail"
            });

            foreach (var (word, definitions) in wordsWithMultipleDefinitions)
            {
                Console.WriteLine($"{word} is defined as :");
                foreach (var definition in definitions)
                {
                    Console.WriteLine($"   {definition}");
                }
            }

            var queue = new Queue<string>();

            queue.Enqueue("this is first");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            foreach (var item in queue)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
