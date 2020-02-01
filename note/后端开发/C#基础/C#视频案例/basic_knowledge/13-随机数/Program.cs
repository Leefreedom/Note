using System;

namespace _13_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rNumber = r.Next(1, 100);//随机数为1-99，包含开始，不包含结束的值
                Console.WriteLine(rNumber);
            }
            Console.ReadKey();
        }
    }
}
