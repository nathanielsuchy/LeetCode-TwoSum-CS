public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var prevValues = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++) {
            // Calculate the difference between target and the current number
            var difference = target - nums[i];
            
            // Check if the difference is a key in prevValues
            if (prevValues.ContainsKey(difference)) {
                return new int[] { prevValues[difference], i };
            }
            
            // If prevValues does not contain the key add the key to the prevValues
            if (!prevValues.ContainsKey(nums[i])) {
                prevValues.Add(nums[i], i);
            }
        }
        
        return new int[]{};
    }
}
