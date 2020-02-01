using System;

namespace _17_函数方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、读取输入的值，多次调用，输入数字，返回成功，否则重新输入
            Console.WriteLine("请输入一个数字");
            String s = Console.ReadLine();
            bool b = IsNumber(s);
            Console.WriteLine("{0}", b);
            Console.ReadKey();
        }

        /// <summary>
        /// 判断输入的值是不是一个数值
        /// </summary>
        /// <param name="strNumber">输入的值</param>
        /// <returns>布尔值</returns>
        public static bool IsNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return true;
                }
                catch
                {
                    Console.WriteLine("重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }
    }
}
