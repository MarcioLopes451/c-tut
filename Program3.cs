// // methods 

// using System;

// namespace CallingMethods
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string designer = "Anders Hejlsberg";
//       Console.WriteLine(designer);
//       int indexOfSpace = designer.IndexOf(" ");
//       int indexOfSecondName = indexOfSpace + 1;
//       string secondName = designer.Substring(indexOfSpace, indexOfSecondName);
//       Console.WriteLine(secondName);
//     }
//   }
// }

// using System;

// namespace DefineAMethod
// {
//   class Program
//   {
//     static void VisitPlanets()
//     {
//       Console.WriteLine("You visited many new planets…");
//     }
//     static void Main(string[] args)
//     {
//       VisitPlanets();
//     }
//   }
// }

// using System;

// namespace DefineParameters
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       VisitPlanets(3);
//       VisitPlanets(4);
//       VisitPlanets(5);
//     }

//     static void VisitPlanets(int numberOfPlanets)
//     {
//       Console.WriteLine($"You visited {numberOfPlanets} new planets...");
//     }
//   }
// }

// using System;

// namespace Return
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine(DecoratePlanet("Jupiter"));
//     }
//     static string DecoratePlanet(string str)
//     {
//       return $"*.*.* Welcome to {str} *.*.*";

//     }

//   }
// }

// using System;

// namespace MethodOverloading
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       IntroduceFriends("marc", "cucu");
//       IntroduceFriends("marc", "cucu", "kaje");
//       IntroduceFriends();

//     }
//     static void IntroduceFriends(string friend1, string friend2)
//     {
//       Console.WriteLine($"These are my friends, {friend1} and {friend2}!");
//     }

//     static void IntroduceFriends(string friend1, string friend2, string friend3)
//     {
//       Console.WriteLine($"These are my friends, {friend1}, {friend2}, and {friend3}!");
//     }

//     static void IntroduceFriends()
//     {
//       Console.WriteLine("There is no one who needs to be introduced.");
//     }
//   }
// }

// using System;

// namespace OutParameters
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string scoreAsString = "85.6";
//       string statement = "Hello World";

//       double scoreAsDouble;
//       bool outcome;

//       outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

//       Console.WriteLine($"{outcome}, {scoreAsDouble}");

//       string whispered = Whisper(statement, out bool marker);
//       Console.WriteLine(whispered);
//     }

//     static string Whisper(string phrase, out bool wasWhisperCalled)
//     {
//       wasWhisperCalled = true;
//       return phrase.ToLower();
//     }
//   }
// }

// using System;

// namespace OptionalParameters
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       VisitPlanets(3);
//       VisitPlanets(4);
//       VisitPlanets(5);
//       VisitPlanets();
//     }

//     static void VisitPlanets(int numberOfPlanets = 0)
//     {
//       Console.WriteLine($"You visited {numberOfPlanets} new planets...");
//     }
//   }
// }

// using System;

// namespace NamedArguments
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       VisitPlanets();
//       VisitPlanets(numberOfPlanets: 2);
//       VisitPlanets(numberOfPlanets: 2, name: "Farfel");
//     }

//     static void VisitPlanets(
//       string adjective = "brave",
//       string name = "Cosmonaut",
//       int numberOfPlanets = 0,
//       double gForce = 4.2)
//     {
//       Console.WriteLine($"Welcome back, {adjective} {name}.");
//       Console.WriteLine($"You visited {numberOfPlanets} new planets...");
//       Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
//     }
//   }
// }

// // projects

// using System;

// namespace ArchitectArithmetic
// {
//   class Program
//   {
//     public static void Main(string[] args)
//     {
//       double totalArea = Rec(2500, 1500) + Circles(375) + Tri(500, 750);

//       double flooringMats = Math.Round(totalArea * 180, 2);
//       Console.WriteLine($"the total cost for the flooring material is {flooringMats} mexican pesos.");
//     }

//     static double Rec(double length, double width)
//     {
//       return length * width;
//     }
//     static double Circles(double radius)
//     {
//       return Math.PI * Math.Pow(radius, 2);
//     }
//     static double Tri(double bottom, double height)
//     {
//       return 0.5 * bottom * height;
//     }

//   }
// }

// custom classes 
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");

      f.trees = 4;
      f.age = 200;
      Console.WriteLine(f.name);
    }
  }
}


internal class Forest
{
  public string name;
  public string biome;
  public int trees;
  public int age;

  public int Grow()
  {
    this.trees += 30;
    this.age++;
    return this.trees;
  }
  public int Burn()
  {
    trees -= 20;
    age++;
    return trees;
  }

  public Forest(string name, string biome)
  {
    this.name = name;
    this.biome = biome;
    this.age = 1;
  }

}


// projects

namespace StarLifecycleSimulator
{
  class Star
  {
    public string name;
    public string type;
    public int age;
    public double brightness;

    public Star(string name, string type)
    {
      this.name = name;
      this.type = type;
      this.age = 0;
      this.brightness = 1.0;
    }

    public Star(string name)
    {
      this.name = name;
      this.type = "Unknown";
      this.age = 0;
      this.brightness = 1.0;
      Console.WriteLine("Star type set to default: Unknown.");
    }

    public void Shine()
    {
      Console.WriteLine($"Star {this.name} is shining with brightness {this.brightness}.");
    }

    public void GrowOlder()
    {
      this.age += 1000000000; // Adds 1 billion years
      this.brightness *= 0.9; // Brightness decreases by 10%
      Console.WriteLine($"Star {this.name} is now {this.age} years old. Brightness: {this.brightness}");
    }

    public void Supernova()
    {
      this.brightness = 0;
      Console.WriteLine($"Star {this.brightness} has exploded in a supernova.");
    }
  }
}


namespace StarLifecycleSimulator
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Star Simulations */

      Star sun = new Star("Sun", "G-Type");
      sun.Shine();
      sun.GrowOlder();
      sun.Shine();
      sun.Supernova();

      Star unknownStar = new Star("Mystery Star");
      unknownStar.Shine();
      unknownStar.GrowOlder();
    }
  }
}