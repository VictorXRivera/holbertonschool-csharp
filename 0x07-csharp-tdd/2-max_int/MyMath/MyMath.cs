using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Operations class </summary>
    public class Operations
    {
        /// <summary> Finding max integer in list of ints </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }
            
            int max = nums.Max();
            return (max);
        }
    }
}