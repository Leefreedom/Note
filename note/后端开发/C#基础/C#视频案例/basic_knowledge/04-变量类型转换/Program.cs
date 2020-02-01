using System;

namespace _04_变量类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------类型转换

            //自动类型转换
            /* 小>>=大（隐式转换）
             * int a = 10;
             * double b = a * 1.0;//隐式转换成double
             */
            /* 大>>=小 (显式转换)
            *  int result = (int)303.1;
            *  Console.WriteLine(result);
            *  Console.ReadKey();
            */

            //-------强制类型转换------大>>=小
            /*Console.WriteLine("请输入语文成绩");
            string strChinese = Console.ReadLine();
            double chinese = Convert.ToDouble(strChinese);
            Console.WriteLine("请输入数学成绩");
            string strMath = Console.ReadLine();
            double math = Convert.ToDouble(strMath);
            Console.WriteLine("请输入英语成绩");
            string strEnglish = Console.ReadLine();
            double english = Convert.ToDouble(strEnglish);
            Console.WriteLine("语文成绩为{0},数学成绩为{1},英语成绩为{2},总成绩为{3},平均成绩为{4:0.00}", chinese, math, english, chinese + math + english, (chinese + math + english) / 3);
            Console.ReadKey();*/
        }
    }
}
