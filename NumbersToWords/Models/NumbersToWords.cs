using System;
using System.Collections.Generic;

namespace NumberToWords.Models
{
  public class NTW
  {
    public static string NumsToWs(string myNumber)
    {
      List<char> numsList = new List<char>{};
      string finalString = "";
      for(int i = myNumber.Length-1; i>=0; i--)
      {
        // Console.WriteLine(myNumber[i]);
        numsList.Add(myNumber[i]);
      }
      
      for(int i = 0; i < numsList.Count; i++)
      {
        switch(numsList[i])
        {
          case '1':
            finalString = finalString.Insert(0, "one");
            break;
          case '2':
            finalString = finalString.Insert(0, "two");
            break;
          case '3':
            finalString = finalString.Insert(0, "three");
            break;
          case '4':
            finalString = finalString.Insert(0, "four");
            Console.WriteLine("=> "+finalString);
            break;
          case '5':
            finalString = finalString.Insert(0, "five");
            break;
          case '6':
            finalString = finalString.Insert(0, "six");
            break;
          case '7':
            finalString = finalString.Insert(0, "seven");
            break;
          case '8':
            finalString = finalString.Insert(0, "eight");
            break;
          case '9':
            finalString = finalString.Insert(0, "nine");
            break;
          default:
            return "error";
        }
      }
      return finalString;
    }
    
  }
}