using System;
using System.Collections.Generic;

namespace SwopTheStrings
{
    public class Swoping
    {
      public  static void Main(string[] args)
      {
         List<string> catsBreed= new List<string>();
      
         
            Console.WriteLine("Hoe much cats breed do you know?");
            int number = int.Parse((Console.ReadLine()));
         // Console.WriteLine("enter " + number + " breeds of cats, dividing by Enter");
          for (int i = 1; i <= number; i++)
          {
            Console.Write("Cats breed number " + i+ ": ");
            catsBreed.Add(Console.ReadLine());  
          }
          Console.WriteLine("______________________________________________________________________");
          Console.WriteLine("Cats breed in the original order:");
          Console.WriteLine("______________________________________________________________________");
            foreach (var cat in catsBreed)
            {
                Console.WriteLine(cat);
            }

            catsBreed.Reverse();
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("New cats breed order:");
            Console.WriteLine("______________________________________________________________________");
            foreach (var cat in catsBreed)
            {
                Console.WriteLine(cat);
            }
        }
    }
}
