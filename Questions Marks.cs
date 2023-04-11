using System;
using System.Text.RegularExpressions;

class MainClass {

  public static bool QuestionsMarks(string str) {

    if(str.StartsWith("?") || str.EndsWith("?")) return false;

    int count = 0;
    int sum = 0;
    int pair = 0;

    Regex regex = new Regex(@"^[0-9]+$");

    for(int i = 0; i < str.Length; i++) {
      if(str[i].ToString() == "?") {
        count =+ 1;
      }

      if(regex.IsMatch(str[i].ToString())) {
        if(pair == 2) {
          pair = 0;
          sum = 0;
        }

        sum += int.Parse(str[i].ToString());
        pair += 1;
      }

      if(sum == 10) {
        return true;
      }

      if(count == 3) {
        count = 0;
      }
    }

    return false;
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(QuestionsMarks(Console.ReadLine()));
    
  } 

}