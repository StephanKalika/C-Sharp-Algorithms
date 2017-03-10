using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = new int[] {3, 2, 4};

            var res = Solution.TwoSum(nums,6);

            var res2 = Solution.twoSum2(nums,6);
        }


    }

    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }

        public static int[] twoSum2(int[] nums, int target)
        {
            var dict = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
