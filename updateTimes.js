function updateTimes(signalOne, signalTwo) {
    let t = 0;
    let size = signalOne.length <= signalTwo.length ? signalOne.length : signalTwo.length;
  	let s1o = [... new Set(signalOne)];
 	 	let s2o = [... new Set(signalTwo)];
  
  
  	for(let i = 0; i < size; i++) {
    	if(s1o[i] === s2o[i])
        t++;
    }
    
    return t;
}

updateTimes([1,2,3,3,3,5,4], [1,2,3,4,3,5,4])