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
        numsList.Add(myNumber[i]);
      }
      
      for(int i = 0; i < numsList.Count; i++)
      {
        if(i==0)
        {
          switch(numsList[i])
        {
          case '0':
            break;
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
        // if(numsList[i+1] == '1')
        // { WHO DID THIS
        //   finalString+"teen"
        // }
        // }

        // else if (i==1)
        // {
        //   case '1':
        //     finalString = finalString.Insert(0, "ten");
        //     break;
        //   case '2':
        //     finalString = finalString.Insert(0, "two");
        //     break;
        //   case '3':
        //     finalString = finalString.Insert(0, "three");
        //     break;
        //   case '4':
        //     finalString = finalString.Insert(0, "four");
        //     break;
        //   case '5':
        //     finalString = finalString.Insert(0, "five");
        //     break;
        //   case '6':
        //     finalString = finalString.Insert(0, "six");
        //     break;
        //   case '7':
        //     finalString = finalString.Insert(0, "seven");
        //     break;
        //   case '8':
        //     finalString = finalString.Insert(0, "eight");
        //     break;
        //   case '9':
        //     finalString = finalString.Insert(0, "nine");
        //     break;
        //   default:
        //     return "error";
        // }
        
        else if(i==2)
        {
          switch(numsList[i])
          {
          case '0':
            break;
          case '1':
            finalString = finalString.Insert(0, "WEIRD STUFF");
            break;
          case '2':
            finalString = finalString.Insert(0, "twenty");
            break;
          case '3':
            finalString = finalString.Insert(0, "thirty");
            break;
          case '4':
            finalString = finalString.Insert(0, "forty");
            break;
          case '5':
            finalString = finalString.Insert(0, "fifty");
            break;
          case '6':
            finalString = finalString.Insert(0, "sixty");
            break;
          case '7':
            finalString = finalString.Insert(0, "seventy");
            break;
          case '8':
            finalString = finalString.Insert(0, "eighty");
            break;
          case '9':
            finalString = finalString.Insert(0, "ninety");
            break;
          default:
            return "error";
          }
        }
      }
      return finalString;
    }
    
  }
}