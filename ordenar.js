function ordenar(array, oldIndex, newIndex) {
  
    let aux = array[oldIndex];
    
    if(oldIndex > newIndex) {
      for(i = newIndex ; i < array.length; i++) {
        let aux2 = array[i];
        array[i] = aux;
        aux = aux2;
      }
    } else {
      for(i = newIndex;  i > oldIndex - 1; i--) {
        let aux2 = array[i];
        array[i] = aux;
        aux = aux2;
      }
    }
    
    
    return array
  }
  
  ordenar([1,4,2,6,5,8], 5,1) // [1,8,4,2,6,5]
  ordenar([1,4,2,6,5,8], 1,5) // [1,2,6,5,8,4]