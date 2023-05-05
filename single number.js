var singleNumber = function(nums) {
    const pairs = {}
    for(const num of nums) {
        if(pairs[num]) {
            pairs[num] += 1;
        } else {
            pairs[num] = 1;
        }

        if(pairs[num] > 1) {
            delete pairs[num];
        }
    }

    return parseInt(Object.keys(pairs))
};