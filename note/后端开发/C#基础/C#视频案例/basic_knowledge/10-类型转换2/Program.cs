using System;

namespace _10_类型转换2
{
    class Program
    {
        static void Main(string[] args)
        {
            //一般转换
            string str = "123";
            //Convert.ToInt32()方法的底层就是int.Parse()
            //这两个在转换不是正常的字符串时，会报错。
            int n = Convert.ToInt32(str);   //123
            int n1 = int.Parse(str);//123

            //尝试转换
            string str1 = "123a";
            int result;
            //尝试转换str1为int类型

            /* 转换成功时，将值赋给result，并且b为true；
             * 转换失败时，b为false，result赋值为0。
             */
            bool b = int.TryParse(str1, out result);

            Console.WriteLine("b={0},result={1}", b, result);
            Console.ReadKey();

        }
    }
}
