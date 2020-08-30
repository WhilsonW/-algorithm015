public class Solution {
    public int[] TwoSum(int[] nums, int target) {
   for (int i = 0; i < nums.Length; i++) {
                for (int t = i+1; t < nums.Length; t++) {
                    int sum = nums[i]+nums[t];
                    if (sum==target) {
                        return new int[]{i, t};
                    }
                }
            }
            return new int[2];
    }
}