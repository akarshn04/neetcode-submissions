public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> elemToIndexMap = new();
        for(int i=0;i<nums.Length;i++)
        {
            if(!elemToIndexMap.ContainsKey(nums[i]))
            {
                elemToIndexMap.Add(nums[i],i);
            }
        }
        for(int i=0;i<nums.Length;i++)
        {
            int diff = target - nums[i];
            if(elemToIndexMap.ContainsKey(diff) && elemToIndexMap[diff]!=i)
            {
                return new int[]{i, elemToIndexMap[diff]};
            }
        }
        return new int[0];
    }
}
