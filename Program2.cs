using System;

namespace EqualityOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      int cookiesSoldGuess = 250;
      int storeOneCookies = 110;
      int storeTwoCookies = 135;
      int cookiesSoldActual = storeOneCookies + storeTwoCookies;
      bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;
      Console.WriteLine(guessedCorrect);
      // 

      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;
      double tripDuration = distance / rate;
      bool answer = tripDuration <= timeToDinner;
      Console.WriteLine(answer);
      // 
      bool beach = true;
      bool hiking = false;
      bool city = true;
      bool yourNeeds = beach && city;
      bool friendNeeds = beach || hiking;
      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);
    }
  }
}

// using System;

public class SpaceExpedition
{
  public static void Main(string[] args)
  {
    // Your code goes here
    bool isAtmosphereBreathable = true;
    bool isGravityStable = false;
    bool resourcesSufficient = true;
    bool isHabitable = isAtmosphereBreathable && isGravityStable;
    Console.WriteLine(isHabitable);
    bool suitableForExpansion = isGravityStable || resourcesSufficient;
    Console.WriteLine(suitableForExpansion);
    int currentCrew = 5;
    int maxCrewCapacity = 10;
    bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;
    Console.WriteLine(canAcceptMoreCrew);
  }
}


// conditional statements 

using System;

namespace IfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int socks = 6;
      if (socks <= 3)
      {
        Console.WriteLine("Time to do laundry!");
      };

      int people = 11;
      string weather = "nice";
      if (people <= 10 && weather == "nice")
      {
        Console.WriteLine("SaladMart");
      }
      else
      {
        Console.WriteLine("Soup N Sandwich");
      };

      double ph = 7;
      if (ph < 7)
      {
        Console.WriteLine("Acidic");
      }
      else if (ph > 7)
      {
        Console.WriteLine("Basic");
      }
      else
      {
        Console.WriteLine("Neutral");
      }

      double ph = 14;

      switch (ph)
      {
        case <= 3:
          Console.WriteLine("Very Acidic");
          break;
        case < 7:
          Console.WriteLine("Acidic");
          break;
        case >= 11:
          Console.WriteLine("Very Basic");
          break;
        case > 7:
          Console.WriteLine("Basic");
          break;
        default:
          Console.WriteLine("Neutral");
          break;
      }

      int pepperLength = 4;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
      Console.WriteLine(message);
    }
  }
}


// project password checker

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "1234567890";
      string specialChars = "!@£$%^&*?";

      Console.WriteLine("enter password");
      string input = Console.ReadLine();
      Console.WriteLine(input);

      int score = 0;
      int inputLength = input.Length;

      if (inputLength >= minLength)
      {
        score++;
      }
      if (Tools.Contains(input, uppercase))
      {
        score++;
      };
      if (Tools.Contains(input, lowercase))
      {
        score++;
      };
      if (Tools.Contains(input, digits))
      {
        score++;
      };
      if (Tools.Contains(input, specialChars))
      {
        score++;
      };
      Console.WriteLine(score);

      switch (score)
      {
        case 4:
          Console.WriteLine("Password is really strong");
          break;
        case 3:
          Console.WriteLine("Password is strong");
          break;
        case 2:
          Console.WriteLine("Password is medium");
          break;
        case 1:
          Console.WriteLine("Password is weak");
          break;
        default:
          Console.WriteLine("password doesnt meet standards.");
          break;
      }
    }
  }
}

// project two

using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or NO:");
      string noiseChoice = Console.ReadLine().ToUpper();
      if (noiseChoice == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      }
      else if (noiseChoice == "YES")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
        Console.WriteLine("Type OPEN or KNOCK:");
        string doorChoice = Console.ReadLine().ToUpper();

        if (doorChoice == "KNOCK")
        {
          Console.WriteLine("A voice behind the door speaks. It says, 'Answer this riddle:' 'Poor people have it. Rich people need it. If you eat it, you die. What is it?'");
          Console.WriteLine("Type your answer:");
          string riddleAnswer = Console.ReadLine().ToUpper();

          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END");
          }
          else
          {
            Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
          }
        }
        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.WriteLine("Enter a number (1-3):");
          string keyChoice = Console.ReadLine();

          switch (keyChoice)
          {
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...THE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
              break;
            default:
              Console.WriteLine("Invalid choice. THE END.");
              break;
          }
        }
        else
        {
          Console.WriteLine("You didn't choose a valid option. THE END.");
        }
      }
    }
  }
}


// arrays 

using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {

      string[] summerStrut;
      summerStrut = new string[] { "Juice", "Missing U", "674", "410", "86", "Harlem", "150", "WossipDrive" };
      int[] ratings = { 1, 2, 3, 4, 5, 1, 2, 4 };

      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito" };

      if (summerStrut.Length == 8)
      {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      }
      else if (summerStrut.Length > 8)
      {
        Console.WriteLine("Too many songs!");
      }
      else
      {
        Console.WriteLine("Add some songs!");
      }

      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      Console.WriteLine($"You rated {summerStrut[1]} {ratings[1]}.");

      summerStrut[7] = "hello kitty";
      ratings[7] = 5;

      int index = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {index + 1} is rated three stars.");

      Array.Reverse(summerStrut);
      Console.WriteLine($"first song is {summerStrut[0]} and last song is {summerStrut[7]}");

      Array.Sort(summerStrut);
      Console.WriteLine($"first song is {summerStrut[0]} and last song is {summerStrut[7]}");

    }
  }
}

// array project 

using System;

namespace SpaceMission
{
  class Program
  {
    static void Main(string[] args)
    {
      // Your code goes here
      string[] spaceInventory;
      spaceInventory = new string[] { "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools" };

      int[] itemQuantities = { 10, 8, 15, 5, 6, 9, 4, 7 };

      if (spaceInventory.Length == 8)
      {
        Console.WriteLine("Space Inventory is ready to go!");
      }
      else if (spaceInventory.Length > 8)
      {
        Console.WriteLine("Too many items!");
      }
      else
      {
        Console.WriteLine("Add more items!");
      }
      Console.WriteLine($"{spaceInventory[1]}, {itemQuantities[1]}");

      spaceInventory[7] = "Scientific Instruments";
      itemQuantities[7] = 5;

      int inde = Array.IndexOf(itemQuantities, 5);
      Console.WriteLine($"The first item with quantity 5 is at position {inde + 1}.");

      Array.Reverse(spaceInventory);
      Console.WriteLine($"first inventory is {spaceInventory[0]} and last inventory is {spaceInventory[7]}");

      Array.Sort(spaceInventory);
      Console.WriteLine($"first inventory is {spaceInventory[0]} and last inventory is {spaceInventory[7]}");

    }
  }
}