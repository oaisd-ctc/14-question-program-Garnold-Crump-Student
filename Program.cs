using System;

namespace Questions
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("What is your name");
      string firstName = Console.ReadLine();



      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine("What is your eye color?");
      string eyeColor = Console.ReadLine();


      Console.WriteLine("What is your hair color?");
      string hairColor = Console.ReadLine();

      Console.WriteLine("What is your shoe size");
      int shoeSize = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine("What is your favorite color?");
      string favoriteColor = Console.ReadLine();


      Console.WriteLine("What is your favorite tv show?");
      string tvShow = Console.ReadLine();


      Console.WriteLine("who is your favorite teacher?");
      string favTeacher = Console.ReadLine();


      Console.WriteLine("what is your favorite class?");
      string favClass = Console.ReadLine();


      Console.WriteLine("what is your favorite holiday?");
      string favHoliday = Console.ReadLine();


      Console.WriteLine("what is your favorite season?");
      string favSeason = Console.ReadLine();


      Console.WriteLine("what is your dream job?");
      string dreamJob = Console.ReadLine();




      Console.WriteLine("How many siblings do you have");
      string siblings = Console.ReadLine();


      Console.WriteLine("my friends name is " + (firstName) + " they are " + (age) + " and in 5 years he is " + (age + 5) + " there Eye color is " + (eyeColor) +
      " there hair color is " + (hairColor) + " there shoe size is " + (shoeSize) + " there favorite color is " + (favoriteColor) + " there favorite tv show is " + (tvShow) + " there favorite teacher is " + (favTeacher) + " there favorite class is " + (favClass) + " there holiday is " + (favHoliday) + " there dream job is " + (dreamJob) + " they have " + (siblings) + " siblings ");



    }
  }
}