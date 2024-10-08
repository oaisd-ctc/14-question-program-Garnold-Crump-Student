using System;

namespace Questions
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("What is your name");
      string firstName = Console.ReadLine();
      Console.WriteLine("Your name is " + (firstName));


      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + age);

      Console.WriteLine("What is your eye color?");
      string eyeColor = Console.ReadLine();
      Console.WriteLine("Your eye color is " + (eyeColor));

      Console.WriteLine("What is your shoe size");
      int shoeSize = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your shoe size is " + (shoeSize));

      Console.WriteLine("What is your favorite color?");
      string favoriteColor = Console.ReadLine();
      Console.WriteLine("Your favorite color is " + (favoriteColor));

      Console.WriteLine("What is your favorite tv show?");
      string tvShow = Console.ReadLine();
      Console.WriteLine("Your tv show is " + (tvShow));

      Console.WriteLine("who is your favorite teacher?");
      string favTeacher = Console.ReadLine();
      Console.WriteLine("your favorite teacher is " + (favTeacher));

      Console.WriteLine("what is your favorite class?");
      string favClass = Console.ReadLine();
      Console.WriteLine("your favorite class is " + (favClass));

      Console.WriteLine("what is your favorite holiday?");
      string favHoliday = Console.ReadLine();
      Console.WriteLine("your favorite holiday is " + (favHoliday));

      Console.WriteLine("what is your favorite season?");
      string favSeason = Console.ReadLine();
      Console.WriteLine("your favorite season is " + (favSeason));

         Console.WriteLine("what is your dream job?");
      string dreamJob = Console.ReadLine();
      Console.WriteLine("your dream job is " + (dreamJob));

      Console.WriteLine("your age in 5 years is");
       Console.WriteLine(" " + (age + 5));

         Console.WriteLine("How many siblings do you have");
      string siblings = Console.ReadLine();
      Console.WriteLine("you have " + (siblings)+ " Siblings");





    }
  }
}