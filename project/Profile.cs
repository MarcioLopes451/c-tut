using System;

namespace DatingProfile
{
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }
    public string ViewProfile()
    {
      string pro = $"name: {this.name},\nage: {this.age},\ncity: {this.city},\ncountry: {this.country},\npronouns: {this.pronouns}";

      pro += "\nhobbies:";
      foreach (string hobby in hobbies)
      {
        pro += $"- {hobby}";
      };
      return pro;
    }
    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
