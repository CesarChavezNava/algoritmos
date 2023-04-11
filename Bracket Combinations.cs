using System;

class MainClass {

  public static int BracketCombinations(int num) {

    // Si num es 0, solo hay una combianción valida y es el string vacio
    if(num == 0) {
      return 1;
    }

    int count = 0;

    /*
      close < open
      0 - 1 * 3 - 1 - 0 = 2 = 0
      De un lado todos los abiertos y del otro todos los cerrados
    */

    for(int i = 0; i < num; i++) {
      // Es un arbol
      count += BracketCombinations(i) * BracketCombinations(num - 1 - i);
    }

    return count;
  }



  static void Main() {  

    // keep this function call here
    Console.WriteLine(BracketCombinations(Console.ReadLine()));
    
  } 

}