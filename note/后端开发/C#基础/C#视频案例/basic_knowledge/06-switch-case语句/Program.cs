using System;

namespace _06_switch_case语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个5以内的数字");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0: Console.WriteLine("您输入的是0");break;
                case 1: Console.WriteLine("您输入的是1");break;
                case 2: Console.WriteLine("您输入的是2");break;
                case 3: Console.WriteLine("您输入的是3");break;
                case 4: Console.WriteLine("您输入的是4");break;
                case 5: Console.WriteLine("您输入的是5");break;
            }
            Console.ReadKey();
        }
    }
}
