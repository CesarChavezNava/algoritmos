using System;
using System.Collections;

class MainClass {

  public static string BracketMatcher(string str) {
    int stack = 0;
    for(int i = 0; i < str.Length; i++) {
      if(str[i] == '(') {
        stack += 1;
      } else if(str[i] == ')') {
        if(stack == 0) {
          return "0";
        }
        stack -= 1;
      }
    }

    return stack == 0 ? "1" : "0";
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(BracketMatcher(Console.ReadLine()));
    
  } 
}