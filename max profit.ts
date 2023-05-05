function maxProfit(prices: number[]): number {
    let diff = 0;
    let day = 0;
    
    let up = {};
    
    for(let i = 0; i < prices.length; i++) {
        if(!up[prices[i]]) {
            up[prices[i]] = i;    
        
            for(let j = i; j < prices.length; j++) {
                if(prices[j] - prices[i] > diff) {
                    diff = prices[j] - prices[i];
                }
            }
        }
    }
    
    return diff;
};