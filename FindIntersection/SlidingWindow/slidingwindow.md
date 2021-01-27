``` c#

using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {

  
  private static List<double> result = new List<double>();
  private static int sw = 0;
  private static int n = 0;
  private static int[] listOfNumbers { get; set; }

  public static string ArrayChallenge(int[] arr) {   
    sw = arr[0];
    listOfNumbers = new int[arr.Length - 1];     
    Array.Copy(arr, 1, listOfNumbers, 0, arr.Length-1);
    
    
    int i=arr.Min();      
    int count = 1;

    var until = 0;
    if(i < 0)
    {
      until = sw;
    } else
    {
      until = sw - 1;
    }
    while(count < until)
    {
      if(i < 0)
      {
        result.Add(0);
      } 
      else 
      {
        result.Add(i);
      }
      count++;
      i++;
    }

    var currentWindow = GetSlidingWindow(listOfNumbers);
    var currentMedian = GetMedianFromCurrentWindow(currentWindow);
    result.Add(currentMedian);
    GetNextSlidingWindow();
  
    if (!arr.Contains(0))
    {
      return String.Join(",", result.Where(x => x != 0).ToArray());
    }
    else {
      return String.Join(",", result.ToArray());
    }
    
  }

  private static void GetNextSlidingWindow()
  {
    n++;
    var currentWindow = GetSlidingWindow(listOfNumbers);
    if(currentWindow != null)
    {
      var currentMedian = GetMedianFromCurrentWindow(currentWindow);
      result.Add(currentMedian);
      GetNextSlidingWindow();
    }
  }

  private static double GetMedianFromCurrentWindow(int[] currentWindow)
  {
    if(currentWindow != null)
    {
      Array.Sort(currentWindow);
      if((currentWindow.Length % 2) == 0)
      {
        var i1 = currentWindow.Length / 2;
        var i2 = i1 + 1;
        return (double) (currentWindow[i1 - 1] + currentWindow[i2-1]) / 2;
      }
      else
      {
        var i = (currentWindow.Length - 1) / 2;
        return currentWindow[i];
      }
    }
    else
    {
      return 0;
    }
   
  }

  private static int[] GetSlidingWindow(int[] listOfNumbers) {
      try
      {
        var w = new int[sw];
        Array.Copy(listOfNumbers, n, w, 0, sw);
        return w;
      }
      catch
      {
        return null;
      }
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}

```
