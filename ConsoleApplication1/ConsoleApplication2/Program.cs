using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[1001];
            for (int i = 0; i < 1001; i++)
            {
                nums[i] = i + 1;
            }

            /*func1*/
            //for (int i = 0; i < 1001; i++)
            //{
            //    nums[1000] += nums[i];
            //    Debug.WriteLine("{0}----{1}------{2}",i,nums[i],nums[1000]);
            //}
            //nums[1000] -= 1001*1000/2;
            //Console.WriteLine(nums[1000]);

            /*func2*/
            for (int i = 1; i < 1001; i++)
            {
                nums[0] = nums[0] ^ nums[i];
            }

            nums[1] = 1;
            for (int i = 2; i < 1001; i++)
            {
                nums[1] = nums[1] ^ i;
            }

            Console.WriteLine(nums[0] ^ nums[1]);



            Console.Read();
        }
    }
}
