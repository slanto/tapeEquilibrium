namespace TapeEquilibrium.Core
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int GetTapeEquilibrium(int[] a)
        {
            int minimalDiff = -1;
            var left = 0;
            var sum = a.Sum();
            foreach (int t in a)
            {
                left += t;
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
