public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs)
        {
            var count = s.Length;
            sb.Append(count).Append('#').Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        int i=0;
        while(i<s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int len = Int32.Parse(s.Substring(i,j-i)); //string can be like 123#abc => this will get us "123"
            i = j+1;
            j = i+len;
            res.Add(s.Substring(i,len));
            i=j;
        }
        return res;
   }
}
