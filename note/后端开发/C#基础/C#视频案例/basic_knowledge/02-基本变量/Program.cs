using System;

namespace _02_基本变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------基本变量
            /*int number = 10;
            double d = 3.14;
            string name = "张三";
            char gender = '男';
            decimal money = 1000;
            number = 200;
            Console.WriteLine(number);
            Console.WriteLine(d);
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(money);
            Console.ReadKey();*/

            //-------占位符
            /*int numOne = 10;
            int numTwo = 20;
            int numThree = 30;
            Console.WriteLine("第一个数字{0}，第二个数字{1}，第三个数字{2}", numOne, numTwo, numThree);
            Console.ReadKey();*/

            //-------小数点取前两位    (在占位符中操作)
            /*int a = 10;
            int b = 3;
            int c = a % b;
            double q = (a * 1.0) / b;//3.3333333333333335
            Console.WriteLine("{0:0.00}", q);//3.33
            Console.ReadKey();*/
        }
    }
}
