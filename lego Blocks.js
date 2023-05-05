function legoBlocks(n, m) {
    let blocks = [1,2,3,4];
    
    let h = 0;
    let w = 0;
    let ww = [];
    let wall = [];
    let i = 0;
    let j = 1;
    
    while (h < n) {
      while(w < m) {
          w += blocks[i];
          if(w > m) {
              w -= blocks[i];
              i -= 2;
          } else {
            ww.push(blocks[i]);
          }

          i++;
      }
      
      wall.push(ww);
      
      h++
      i = j;
      j++;
      
      w = 0;
      ww = [];
    }
    
  
  console.log(wall)
}

legoBlocks(2,2)