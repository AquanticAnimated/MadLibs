using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a mad lip game that will prompt user to fill in the blanks
            Author: Codecademy ft. Sindi
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Lips Game is about to start!! \n Make sure to clear your mind and read the text carfully! \nWhen you are ready, press any key to start (except the ESC lol)");
            Console.ReadLine();

            // Give the Mad Lib a title:
            string title = "THIS MORNING";

            Console.WriteLine(title);
            // Define user input and variables:
            // ASKING FOR A NAME
            Console.WriteLine("Enter a Name : ");
            string name = Console.ReadLine();
            //ASKING FOR 3 ADJECTIVES
            Console.WriteLine("Now we need 3 Adjectives. \nType in your first Adjective : ");
            string adjectiveOne = Console.ReadLine();
            Console.WriteLine("Type in your second Adjective : ");
            string adjectiveTwo = Console.ReadLine();
            Console.WriteLine("Type in your last Adjective : ");
            string adjectiveThree = Console.ReadLine();
            //ASKING FOR 1 VERB
            Console.WriteLine("Now we need 1 Verb. \nType in your verb / action : ");
            string verb = Console.ReadLine();
            //ASKING FOR 2 NOUNS
            Console.WriteLine("Now we need 2 Nouns. \nType in your first Noun : ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Type in your second Noun : ");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("This is going to be so much fun 3:) !! \n Press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine("Just a few more words and we will present you work of ART.");

            //ASKING FOR 1 OF EACH : ANIMAL, FOOD, FRUIT, SUPERHERO, COUNTRY, DESSERT, YEAR
            Console.WriteLine("Think of an animal and type it in : ");
            string animal = Console.ReadLine();
            Console.WriteLine("Think of a food and type it in : ");
            string food = Console.ReadLine();
            Console.WriteLine("Think of a fruit and type it in : ");
            string fruit = Console.ReadLine();
            Console.WriteLine("Think of a superhero that flies and type it in : ");
            string superhero = Console.ReadLine();
            Console.WriteLine("Think of a country and type it in : ");
            string country = Console.ReadLine();
            Console.WriteLine("Think of a dessert and type it in : ");
            string dessert = Console.ReadLine();
            Console.WriteLine("Think of a year and type it in : ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {nounTwo}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

            // Print the story:
            Console.WriteLine("Phew!! All that typing and thinking must have tired you, but the good new is that with that we are done!! \n");
            Console.WriteLine("Time to find out the result  \n press ENTER to reveal the story you created.");
            Console.ReadLine();

            Console.WriteLine(story);
        }
    }
}
