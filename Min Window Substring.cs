using System;
using System.Collections.Generic;

class MainClass {

  public static string MinWindowSubstring(string[] strArr) {

    string s = strArr[0];
    string t = strArr[1];
    // {"ahffaksfajeeubsne", "jefaa"}
    // SEARCH = "jefaa"
    // WINDOW = "ahffaksfajeeubsne"

    // SEARCH
    /*
      J = 1
      E = 1
      F = 1
      A = 2
    */

    // Llenar un diccionario con las veces que se necesita que aparezca
    Dictionary<char, int> dict = new Dictionary<char, int>();
    foreach (char c in t) {
        if (!dict.ContainsKey(c)) {
            dict.Add(c, 1);
        } else {
            dict[c] += 1;
        }
    }

    // Empezar a contar desde la izquierda
    int left = 0;
    // Empezar a contar desde la derecha
    int right = 0;
    // El total de valores en el diccionario
    int count = dict.Count;
    // Se da un valor maximo al valor minimo por que al buscar el valor minimo, cualquier valor deberia
    // ser menor al maximo entero
    int minLen = int.MaxValue;
    // Valor para concatenar el resultado
    string result = "";

    
    while (right < s.Length) {
        // Se le asigna la letra
        char c = s[right];
        // Validar si esa letra existe en el diccionario
        if (dict.ContainsKey(c)) {
            // Si existe se resta el numero de apariciones
            dict[c]--;
            // Si las apariciones son igual a 0, quiere decir que ya esta completa la busqueda para esa letra
            if (dict[c] == 0) {
                // Se resta la letra
                count--;
            }
        }

        // Avanzar hacia la derecha
        right++;

        // Si las letras ya se han encontrado
        while (count == 0) {
          // Valida que el numero de letras sea menor a los resultados anteriores
          if (right - left < minLen) {
              // Si es menor, se asigna el nuevo valor minimo
              minLen = right - left;
              // Se corta el valor [N, M]
              result = s.Substring(left, minLen);
          }

          char c2 = s[left];
          if (dict.ContainsKey(c2)) {
            dict[c2]++;
            if (dict[c2] > 0) {
                count++;
            }
          }
          left++;
        }
    }

    return result;

  }

  // 1. Encuentra la maxima cadena que contiene los elementos
  // 2. Avanza en s y si ese tiene los valores avanza en t
  // 3. Compara si ese nuevo resultado es menor al anterior, si asi es toma esos valores, si no 
  //    repite el paso 2 

  static void Main() {  

    // keep this function call here
    Console.WriteLine(MinWindowSubstring(Console.ReadLine()));
    
  } 

}