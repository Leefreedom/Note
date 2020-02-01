using System;

namespace _03_接收用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------接收用户输入
            Console.WriteLine("请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入您的性别");
            string gender = Console.ReadLine();
            Console.WriteLine("{0}您好，您的年龄为{1},性别{2}", name, age, gender);
            Console.ReadKey();

            //-------字符转义
            /*string name1 = "C:\\Users\\Administrator\\Desktop";//第一种方式
            string name2 = @"C:\Users\Administrator\Desktop";//第二种方式*/
        }
    }
}
