public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] left = new int [nums.Length];
        int[] right = new int [nums.Length];
        int leftProd = 1;
        for(int i=0;i<nums.Length;i++)
        {
            if(i==0)
            {
                left[i] = leftProd;
            }
            else
            {
                leftProd *= nums[i-1];
                left[i] = leftProd;
            }
        }
        
        int rightProd = 1;
        for(int j=nums.Length-1;j>=0;j--)
        {
            if(j==nums.Length-1)
            {
                right[j] = rightProd;
            }
            else 
            {
                rightProd *= nums[j+1];
                right[j] = rightProd;
            }
        }

        var res = new int [nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            res[i] = left[i]*right[i];
        }
        return res;
    }
}
