public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> elemToIndexMap = new();
        for(int i=0;i<nums.Length;i++)
        {
                var diff = target - nums[i];
                if(elemToIndexMap.ContainsKey(diff))
                {
                    return new int[]{elemToIndexMap[diff],i};
                }
                elemToIndexMap[nums[i]] = i;
        }
            return null;
    }
}
