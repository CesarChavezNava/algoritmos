using System;
using System.Collections.Generic;

class MainClass {

  public static string FindIntersection(string[] strArr) {
    string[] left = strArr[0].Split(',');
    string[] right = strArr[1].Split(',');


    List<string> intersection = new List<string>();
    for(int i = 0; i < left.Length; i ++) {
      for(int j = 0; j < right.Length; j++) {
        if(left[i] == right[j]) {
          intersection.Add(left[i]);
          break;
        }
      }
    }
    
    return string.Join(",", intersection);

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FindIntersection(Console.ReadLine()));
    
  } 

}