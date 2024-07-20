public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        int slowPointer = 0;
        for(int fastPointer = 1; fastPointer < nums.Length; fastPointer++){
            if(nums[slowPointer] != nums[fastPointer]){
                slowPointer++;
                nums[slowPointer] = nums[fastPointer];
            }
        }

        return slowPointer + 1;
    }
}
