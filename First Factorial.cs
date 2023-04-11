using System;

class MainClass {

  public static int FirstFactorial(int num) {

    int factorial = num;
    for(int i = num - 1; i > 0; i--) {
      factorial *= i;
    }
    // code goes here  
    return factorial;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
    
  } 

}