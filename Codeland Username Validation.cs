using System;
using System.Text.RegularExpressions;

class MainClass {

  public static bool CodelandUsernameValidation(string str) {
    // Regla 1
    if(str.Length < 4 || str.Length >= 25) {
      return false;
    }

    // Regla 2
    Regex rule2 = new Regex(@"^[a-zA-Z]+$");
    if(!rule2.IsMatch(str[0].ToString())) {
      return false;
    }

    // Regla 3
    Regex rule3 = new Regex(@"^[a-zA-Z0-9_]+$");
    if(!rule3.IsMatch(str)) {
      return false;
    }

    // Regla 4
    if(str.EndsWith("_")) {
      return false;
    }

    return true;
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    
  } 
}