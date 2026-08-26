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
        var res = new List<int>(k);
        var count = k;
        foreach(var kvp in freqMap.OrderByDescending(x=>x.Value))
        {
           if(count != 0)
           {
            res.Add(kvp.Key);
            count--;
           }
        }
        return res.ToArray();

    }
}
