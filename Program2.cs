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
