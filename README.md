# LeetCode-TwoSum-CS
A solution for LeetCode "TwoSum" in C#

## Explanation
In this problem you need the return the indexes of the two numbers in an array that add up to reach the target value. In my solution I created a Dictionary called `prevValues` where the key is the value in question and the value is the index in the array. I iterate over the list only once and look for the difference in the dictionary of previously seen values.

**Stats**

Runtime: 132 ms, faster than 99.06% of C# online submissions for Two Sum.
Memory Usage: 45.4 MB, less than 7.86% of C# online submissions for Two Sum.

## Solution
```cs
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
```
