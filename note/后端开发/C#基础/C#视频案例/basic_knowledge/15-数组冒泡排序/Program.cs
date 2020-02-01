using System;

namespace _15_数组冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组冒泡排序
            /*int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();*/
            #endregion

            #region 数组升序排列方法
            //int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] nums = { 1, 8, 7, 5, 2, 6, 3, 9, 4, 0 };
            Array.Sort(nums);//Sort方法只能对数组进行升序排列，降序的话，先升序，在调用反转方法Reverse()
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
