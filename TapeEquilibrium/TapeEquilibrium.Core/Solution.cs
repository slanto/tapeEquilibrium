namespace TapeEquilibrium.Core
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int GetTapeEquilibrium(int[] A)
        {            
            int minimalDiff = -1;
            var left = 0;
            var sum = A.Sum();
            for (int i = 0; i < A.Length - 1; i++)
            {                
                left += A[i];
                var right = sum - left;
                var diff = Math.Abs(left - right);
                if (diff < minimalDiff || minimalDiff == -1)
                {
                    minimalDiff = diff;
                }
            }
            return minimalDiff;

        }
    }
}
