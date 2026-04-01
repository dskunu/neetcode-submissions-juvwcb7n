public class Solution {
    public bool hasDuplicate(int[] nums) {
        // brute force
        // 1. sort
        // 2. compare one and next element

        //nums.Sort();

        // for(int i = 0; i < nums.Length - 1; i++){
        //     if(nums[i] == nums[i+1]){
        //         return true;
        //     }
        // }
        // return false;

        // using Dictionary

        HashSet<int> uniqueNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            bool isAlreadyPresent = uniqueNums.Add(nums[i]);
            if(!isAlreadyPresent){
                return true;
            }
        }
        return false;

    }
}