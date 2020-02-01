using System;

namespace _20_项目重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的名称相同，但是参数不同。和返回值无关
            int num = M(1, 2);
            int num1 = M(1, 2, 3);
            Console.WriteLine("{0}-----{1}", num, num1);
            Console.ReadKey();
        }
        public static int M(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        public static void M(string n1, string n2)
        {
            string sum = n1 + n2;
        }
        public static int M(int n1, int n2, int n3)
        {
            int sum = n1 + n2 + n3;
            return sum;
        }
    }
}
