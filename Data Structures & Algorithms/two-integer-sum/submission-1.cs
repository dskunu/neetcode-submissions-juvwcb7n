public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];

        for(int i = 0; i <= nums.Length; i++){
            for(int j = 1; j <= nums.Length -1; j++){
                if(nums[i] + nums[j] == target && i != j){
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }            
        }
        return result;
    }
}
