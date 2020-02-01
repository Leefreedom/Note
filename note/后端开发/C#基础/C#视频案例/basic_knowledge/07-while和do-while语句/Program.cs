using System;

namespace _07_while和do_while语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //while语句
            /* 先条件判断，在执行循环语句 */
            /*int num = 0;
            while (num < 5)
            {
                Console.WriteLine("num={0}", num);
                num++;
            }
           */

            //do-while语句
            /* 先执行在去判断，故至少执行一次 */
            int num1 = 6;
            do
            {
                Console.WriteLine("num1={0}", num1);
                num1++;
            } while (num1 < 5);

            Console.ReadKey();
        }
    }
}
