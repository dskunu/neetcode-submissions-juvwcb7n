public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            bool isAdded = uniqueNums.Add(nums[i]);
            if(!isAdded)
                return true;
    }
    return false;
    }
}