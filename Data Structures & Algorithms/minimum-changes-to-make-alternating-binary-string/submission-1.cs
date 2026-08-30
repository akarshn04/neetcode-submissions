public class Solution {
    public int MinOperations(string s) {
        
        /*
        For string starting with 0, the pattern will be-
            0, 1, 0, 1, 0, 1....
        => even places have 0 and odd indices has 1.

        For strings starting with 1, the pattern will be -
            1, 0, 1, 0, 1, 0,.....
        => even indices has 1 and odd has 0.

        For converting the string to one of the patterns, we would need to flip the values accordingly. If we check for 1st pattern then count of changes of other pattern will be length of string - countOfChanges as the other characters will be changing in that case and finally we will get minimum of the two as we will convert to that pattern where changes need to be done are minimal.
        */

        int countChanges = 0;
        //Check for pattern starting with 0 => changes if we need to convert to 1st pattern.
        for(int i=0;i<s.Length;i++)
        {
            if(i%2 !=0 && s[i]=='0')
            {
                countChanges++;
            }
            else if(i%2 ==0 && s[i]== '1')
            {
                countChanges++;
            }
        }
        var countForAnotherPattern = s.Length - countChanges;
        return Math.Min(countChanges,countForAnotherPattern);
    }
}