public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new();
        foreach(var item in nums)
        {
            if(hash.Contains(item))
                return true;
            hash.Add(item);
        }
        return false;
    }
}