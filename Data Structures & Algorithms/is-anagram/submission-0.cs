public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArr = s.ToCharArray();
        Array.Sort(sArr);
        var s1 = new string(sArr);

        char[] tArr = t.ToCharArray();
        Array.Sort(tArr);
        var t1 = new string(tArr);
        return s1.Equals(t1);

    }
}
