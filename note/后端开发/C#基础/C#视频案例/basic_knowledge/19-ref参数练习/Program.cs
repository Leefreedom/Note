using System;

namespace _19_ref参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //out：侧重于让方法返回多个值，必须在方法内赋值
            //ref：侧重于将外部数据带入函数处理，不需要在方法内赋值，方法为的值就可以
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);//5500
            Console.ReadKey();
        }
        public static void JiangJin(ref double s)
        {
            s += 500;
        }
    }
}
