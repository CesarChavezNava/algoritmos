using System;

class MainClass {

  public static string SnakeCase(string str) {

    string newSentence = string.Empty;
    for(int i = 0; i < str.Length; i++) {
      if(char.IsPunctuation(str[i]) || str[i] == ' ') {
        newSentence += "_";
      } else {
        newSentence += str[i];
      }
    }

    return newSentence.ToLower();

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(SnakeCase(Console.ReadLine()));
    
  } 

}