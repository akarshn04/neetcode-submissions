public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();

        foreach(var s in strs)
        {
            var str = s.ToCharArray();
            Array.Sort(str);
            var sorted = new string(str);
            if(!dict.ContainsKey(sorted))
            {
                dict[sorted] = new List<string>();
            }
            dict[sorted].Add(s);
        }

        return dict.Values.ToList<List<string>>();

    }
    
}
