public class Solution {
    public int MinOperations(string s) {
        int sameCharacters = 0;
        for(int i=1;i<s.Length;i++)
        {
            if(s[i-1]==s[i])
            {
                sameCharacters++;
            }
        }
        var changesRequired = (int)Math.Ceiling(Convert.ToDouble(sameCharacters)/2.0);

        return changesRequired;
    }
}