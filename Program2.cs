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
