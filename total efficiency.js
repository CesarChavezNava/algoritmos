function getTotalEfficiency(skill) {
   
    let skillo = skill.sort((a,b) => b - a);
    
    let la = 1;
    let lb = 1;
    let a = [], b=[];
    for(let i = 0; i < skillo.length; i++) {
        if(la > lb) {
            lb = lb * skillo[i];
            b.push(skillo[i])
        } else {
            la = la * skillo[i];
            a.push(skillo[i])
        }
    }
    
    if(a.length !== b.length)
        return -1;
    
    return la + lb;
    
}

getTotalEfficiency([4,5,4,2,1])
getTotalEfficiency([6,2,1,1,4,3,5])