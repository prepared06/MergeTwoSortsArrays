using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortsArrays
{
    internal static class GenArray
    {
        public static IEnumerable<int> NewArray(int size)
        {
            var rand = new Random();

            var nums = new int[size];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(0, 10);
            }
            return nums;
        }
    }
}
