using System;

namespace _16_函数方法
{

    class Program
    {
        /// <summary>
        /// 模拟全局变量
        /// </summary>
        public static int _a = 3;
        static void Main(string[] args)
        {
            //方法调用，（方法所在的类名.方法）
            Program.GetValue();


            Console.WriteLine("请输入两个数字比较大小");
            Console.WriteLine("第一个数字为：");
            int oneNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("第二个数字为：");
            int twoNum = Convert.ToInt32(Console.ReadLine());
            int max = GetMax(oneNum, twoNum);
            Console.WriteLine("最大值为{0}", max);

            Console.WriteLine("_a={0}", GetA());
            Console.ReadKey();
        }

        /// <summary>
        /// 无返回值，无参数的方法
        /// </summary>

        // void为方法返回值的类型 
        public static void GetValue()
        {
            Console.WriteLine("无返回值，无参数的方法");
        }
        /// <summary>
        /// 比较两个数的最大值
        /// </summary>
        /// <param name="n1">数字一</param>
        /// <param name="n2">数字二</param>
        /// <returns>最大的值</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        /// <summary>
        /// 使用全局变量_a
        /// </summary>
        /// <returns>_a</returns>
        public static int GetA()
        {
            _a += 5;
            return _a;
        }
    }
}
