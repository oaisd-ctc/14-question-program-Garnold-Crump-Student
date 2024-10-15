using System;

namespace Questions
{
  public class Program
  {
    static string firstName;

    static int age;
    static string eyeColor;
    static string hairColor;
    static int shoeSize;
    static string favoriteColor;
    static string tvShow;
    static string favTeacher;
    static string favClass;
    static string favHoliday;
    static string favSeason;
    static string dreamJob;
    static string siblings;

    public static void Main(string[] args)
    {
      AskName();
      AskAge();
      AskEyeColor();
      AskHairColor();
      AskShoeSize();
      AskFavoriteColor();
      AskFavoriteTvShow();
      AskFavoriteTeacher();
      AskFavoriteClass();
      AskFavoriteHoliday();
      AskFavoriteSeason();
      AskDreamJob();
      AskNumberOfSiblings();
      DisplaySummaryMessage();
    }
    public static void AskName()
    {
      Console.WriteLine("What is your name");
      firstName = Console.ReadLine();
    }

    public static void AskAge()

    {
      Console.WriteLine("Enter your age:");
      age = Convert.ToInt32(Console.ReadLine());
    }

    public static void AskEyeColor()
    {
      Console.WriteLine("What is your eye color?");
      eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
      Console.WriteLine("What is your hair color?");
      hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
      Console.WriteLine("What is your shoe size");
      shoeSize = Convert.ToInt32(Console.ReadLine());
    }

    public static void AskFavoriteColor()
    {
      Console.WriteLine("What is your favorite color?");
      favoriteColor = Console.ReadLine();
    }

    public static void AskFavoriteTvShow()
    {
      Console.WriteLine("What is your favorite tv show?");
      tvShow = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
      Console.WriteLine("who is your favorite teacher?");
      favTeacher = Console.ReadLine();
    }

    public static void AskFavoriteClass()
    {
      Console.WriteLine("what is your favorite class?");
      favClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
      Console.WriteLine("what is your favorite holiday?");
      favHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
      Console.WriteLine("what is your favorite season?");
      favSeason = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
      Console.WriteLine("what is your dream job?");
      dreamJob = Console.ReadLine();
    }



    public static void AskNumberOfSiblings()
    {
      Console.WriteLine("How many siblings do you have");
      siblings = Console.ReadLine();
    }

    public static void DisplaySummaryMessage()
    {

      Console.WriteLine("my friends name is " + (firstName) + " they are " + (age) + " and in 5 years he is " + (age + 5) + " there Eye color is " + (eyeColor) +
        " there hair color is " + (hairColor) + " there shoe size is " + (shoeSize) + " there favorite color is " + (favoriteColor) + " there favorite tv show is " + (tvShow) + " there favorite teacher is " + (favTeacher) + " there favorite class is " + (favClass) + " there holiday is " + (favHoliday) + " there dream job is " + (dreamJob) + " they have " + (siblings) + " siblings ");

    }
  }
}

