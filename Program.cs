// using System;

// class Program
// {
//   static void Main(string[] args)
//   {
//     // Your code here
//     Console.WriteLine("Hello, World");
//   }
// }

// understanding Console.WriteLine()

// using System;

// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("Hello Marcio!");
//     }
//   }
// }

// understanding Console.ReadLine()

// using System;

// namespace GettingInput
// {
//   class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("How old are you?");
//       string input = Console.ReadLine();
//       Console.WriteLine($"You are {input} years old!");
//     }
//   }
// }

// using System;

// namespace ConsoleCreatures
// {
//   class Program
//   {
//     static void Main()
//     {
//       // console creature
//       Console.WriteLine(" .-.");
//       Console.WriteLine("o   o");
//       Console.WriteLine("| O |");
//       Console.WriteLine("|   |");
//       Console.WriteLine("'~~~'");
//       Console.WriteLine("creature scum");
//     }
//   }
// }

// datatypes

//  using System;

// namespace Form
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Create Variables
//       string name = "Shadow";
//       string breed = "Golden Retriever";
//       int age = 5;
//       double weight = 65.22;
//       bool spayed = true;
//       // Print variables to the console
//       Console.WriteLine(name);
//       Console.WriteLine(breed);
//       Console.WriteLine(age);
//       Console.WriteLine(weight);
//       Console.WriteLine(spayed);
//     }
//   }
// }

// datatype conversions 

// using System;

// namespace FavoriteNumber
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Ask user for fave number
//       Console.Write("Enter your favorite number!: ");
//       int faveNumber = Convert.ToInt32(Console.ReadLine());
//       // Turn that answer into an int



//     }
//   }
// }


using System;

public class GalacticTravelAgency
{
  public static void Main(string[] args)
  {
    // Your code goes here
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";
    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge + 1);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);
    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine(passengerAgeDouble);
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeDouble2);
  }
}

using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;


      // Number of employees
      int totalEmployees = 86928;


      // Revenue
      decimal revenue = 390819.28m;


      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);

      // Your Age
      int userAge = 24;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      double newEarthAge = userAge + journeyToJupiter;

      double newJupiterAge = newEarthAge / jupiterYears;
      Console.WriteLine(newEarthAge);
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newJupiterAge);

      int steps = 0;

      // Two steps forward 
      steps = steps += 2;

      // One step back 
      steps = steps -= 1;


      // Print result to the console
      Console.WriteLine(steps);

      // Number of students
      int students = 18;


      // Number of students in a group
      int groupSize = 3;


      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How many coins do you want to convert?");
      string totalNumber = Console.ReadLine();
      double number = Math.Floor(Convert.ToDouble(totalNumber));
      Console.WriteLine($"{number} cents is equal to...");

      int goldCoin = 10;
      int silverCoin = 5;
      int bronzeCoin = 1;
      double goldCoins = Math.Floor(number / goldCoin);
      double remainder = number % goldCoin;
      double silverCoins = Math.Floor(number / silverCoin);
      remainder = remainder % silverCoins;
      double bronzeCoins = Math.Floor(number / bronzeCoin);
      remainder = remainder % bronzeCoins;
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {bronzeCoins}");
    }
  }

  using System;

namespace PrideAndPrejudice
  {
    class Program
    {
      static void Main(string[] args)
      {
        // First string variable
        string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";

        // Second string variable
        string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";



        // Print variable and newline
        Console.WriteLine(firstSentence);
        Console.WriteLine("\n");
        Console.WriteLine(firstSpeech);

        string beginning = "Once upon a time,";
        string middle = "The kid climbed a tree";
        string end = "Everyone lived happily ever after.";

        // Interpolate the string and the variables
        string story = $"{beginning} {middle} {end}";


        // Print the story to the console 
        Console.WriteLine(story);

        string password = "a92301j2add";

        // Get password length
        int passwordLength = password.Length;


        // Check if password uses symbol
        int passwordCheck = password.IndexOf("!");



        // Print results
        Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

        // dna strand
        string startStrand = "ATGCGATGAGCTTAC";

        // find location of "tga"
        int tga = startStrand.IndexOf("TGA");


        // start point and stop point variables
        int startPoint = 0;
        int length = tga + 3;


        // define final strand
        string dna = startStrand.Substring(startPoint, length);
        Console.WriteLine(dna);
        // DNA mutation search
        Console.WriteLine(dna[3]);

        string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

        // Get camera directions
        int charPosition = script.IndexOf("Close");
        int length = "Close on".Length;
        string cameraDirections = script.Substring(charPosition, length);

        // Get scene description
        charPosition = script.IndexOf("a portrait");
        string sceneDescription = script.Substring(charPosition);

        // Make camera directions uppercase
        cameraDirections = cameraDirections.ToUpper();


        // Make scene description lowercase
        sceneDescription = sceneDescription.ToLower();

        // Print results
        Console.WriteLine(cameraDirections);
        Console.WriteLine(sceneDescription);

      }
    }
  }

  using System;

namespace MadLibs
  {
    class Program
    {
      static void Main(string[] args)
      {
        /*
        This program ...
        Author: ...
        */
        // Let the user know that the program is starting:
        Console.WriteLine("the mad libs has started");

        // Give the Mad Lib a title:
        string title = "whatever title";

        Console.WriteLine(title);
        // Define user input and variables:
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.WriteLine("give me three adjectives...");
        string adjectiveOne = Console.ReadLine();
        string adjectiveTwo = Console.ReadLine();
        string adjectiveThree = Console.ReadLine();
        Console.WriteLine("give me one verb...");
        string verbOne = Console.ReadLine();
        Console.WriteLine("give me two nouns...");
        string nounOne = Console.ReadLine();
        string nounTwo = Console.ReadLine();
        Console.WriteLine("now i need you to give me a animal...");
        string animal = Console.ReadLine();
        // The template for the story:

        string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep food in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the fruits very {adjectiveThree}. Concerned, {name} texted superhero, who flew {name} to usa and dropped {name} in a puddle of frozen dessert. {name} woke up in the year 2021, in a world where {nounTwo}s ruled the world.";


        // Print the story:
        Console.WriteLine(story);
      }
    }