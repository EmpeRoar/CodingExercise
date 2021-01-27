
``` C#

https://coderbyte.com/challenges#

using System;
using System.Linq;

class MainClass {
  //  [4, 3, 5, 1, 6] 

  // [3,5,6]
  // [1,6]


  // [9,9,4,2]
  // 1

  // [10, 22, 9, 33, 21, 50, 41, 60, 22, 68, 90]
  
  // 10,22,33,50,60,68,90
  // 9, 21, 41,60,68, 90 
  // ...

  public static int ArrayChallenge(int[] arr) {

    Console.WriteLine(String.Join("-", GetPositiveNumbers(arr)));
    // code goes here  
    return arr[0];

  }

  private static int[] GetPositiveNumbers(int[] arr) 
  {
    return arr.ToList().Where(x => x >= 0).ToArray();
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}

```
