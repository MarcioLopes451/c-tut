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