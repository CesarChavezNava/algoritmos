using System;
using System.Linq;

class MainClass {

  public static string LongestWord(string sen) {

    // code goes here  
    string[] words = sen.Split(" ");
    string wordClean = string.Empty;
    string longestWord = string.Empty;
    foreach(string word in words) {
      wordClean = RemovePunctuations(word);
      if(wordClean.Length > longestWord.Length) {
        longestWord = wordClean;
      }
    }

    return longestWord;

  }


  public static string RemovePunctuations(string input) {
    string word = string.Empty;
    foreach(char c in input) {
      if(!char.IsPunctuation(c)) {
        word += c;
      }
    }

    return word;
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(LongestWord(Console.ReadLine()));
    
  } 

}