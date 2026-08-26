public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!freqMap.ContainsKey(nums[i]))
            {
                freqMap.Add(nums[i],0);
            }
            freqMap[nums[i]]++;
        }
        var res = new List<int>();
        foreach(var kvp in freqMap)
        {
            if(kvp.Value >= k)
            {
                res.Add(kvp.Key);
            }
        }
        return res.ToArray();


    }
}
