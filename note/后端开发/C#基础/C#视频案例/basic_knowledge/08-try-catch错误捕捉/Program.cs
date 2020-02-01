using System;

namespace _08_try_catch错误捕捉
{
    class Program
    {
        static void Main(string[] args)
        {
            //错误捕捉
            int num = 0;
            bool b = true;
            Console.WriteLine("请输入数字：");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的字符串不能转换为数字!");
                b = false;
            }
            if (b)
            {
                Console.WriteLine("输入的数字为{0}", num);
            }
            Console.ReadKey();
        }
    }
}
