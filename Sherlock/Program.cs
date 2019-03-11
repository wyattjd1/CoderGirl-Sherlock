using System;

namespace Sherlock
{
    public static class Program
    {
        public static void Main()
        {
            // define arrays for defined groups
            string[] press = { "a reporter from the Times", "a reporter from the Observer" };
            string[] family = { "Mycroft Holmes", "Mrs. Hudson" };
            string[] enemies = { "Professor Moriarty", "Charles ", "Augustus", " Milverton", "John Woodley" };
            string[] loveInterests = { "Irene Adler" };
            string[] friends = { "Inspector Lestrade", "Dr. Watson" };

            // create array to hold defined group arrays 
            string[][] guests = new string[][] { press, family, enemies, loveInterests, friends };

            // get number of guests 
            Console.WriteLine("How many guests are there?");

            // create variable to hold user input 
            int num = int.Parse(Console.ReadLine());

            // create array to hold guests
            string[] guest = new string[num];

            // create loop to ask the user for all guest specified
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Who is there? ");
                guest[i] = Console.ReadLine();
            }

            // Call KnockKnock method, passing in array of static groups and guest array
            // print result
            Console.WriteLine(KnockKnock(guests, guest));

            Console.ReadLine();
        }

        private static string KnockKnock(string[][] guests, string[] guest)
        {
            // currently not in use since not needed given the directives, but implemented just in case
            foreach (string[] group in guests)
            {
                foreach (string person in group)
                {
                    for (int i = 0; i < guest.Length; i++)
                    {
                        //Only part the matters right now..
                        if (guest[i] == "Dr. Watson" || guest[i] == "Mrs. Hudson")
                        {
                            return "Enter";
                        }
                    }

                }
            }
            return "Go Away!(sound of violin music...)";
        }

    }
}
