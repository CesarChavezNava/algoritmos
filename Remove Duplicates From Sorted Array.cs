public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            return 0;
        
        int j = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[j] != nums[i] ) {
                nums[j+1] = nums[i]; 
                j++;
            }
        }
        
        return j+1;
    }
}