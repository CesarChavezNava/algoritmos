function binarySearch(array, l, r, o) {
	if(l > r) return -1
  const m = Math.floor((l+r) / 2);
  
  if(array[m] === o) return m;
  if(array[m] < o) {
    return binarySearch(array, m + 1, r, o);
  } else {
    return binarySearch(array, l, m - 1, o);
  }
 
}

// Arreglo, 0, Array.lenght, valor a buscar
let result = binarySearch([1,5,10,43,101,202], 0, 5, 101);
if(result === -1)
  console.log("El elemento no esta en el array");
else 
  console.log("El elemento se ha encontrado", result);