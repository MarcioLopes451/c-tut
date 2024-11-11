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
