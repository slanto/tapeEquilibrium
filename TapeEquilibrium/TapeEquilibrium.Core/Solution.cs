namespace TapeEquilibrium.Core
{
    using System;

    public class Solution
    {
        public int GetTapeEquilibrium(int[] a)
        {
            int minimalDiff = -1;
            var right = 0;
            var left = 0;
            for (int i = 0; i < a.Length; i++)
            {
                left += a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    right += a[j];
                }
                var diff = Math.Abs(left - right);
                right = 0;
                if (diff < minimalDiff || minimalDiff == -1)
                {
                    minimalDiff = diff;
                }
            }
            return minimalDiff;
        }
    }
}
