using System;

namespace _14_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //数组声明方式一
            int[] nums = new int[10];
            string[] str = new string[10];
            bool[] b1 = new bool[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //数组声明方式二
            int[] nums1 = { 1, 2, 3, 4, 5 };

            Console.ReadKey();
        }
    }
}
