using System;

namespace _05_if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------if语句判断
            Console.WriteLine("请输入用户名：");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            if (username == "admin" && password == "123")
            {
                Console.WriteLine("登录成功");
                Console.ReadKey();
            }
            else if (username != "admin")
            {
                Console.WriteLine("帐号不存在");
                Console.ReadKey();
            }
            else if (username == "admin" && password != "123")
            {
                Console.WriteLine("密码错误");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("登录失败");
                Console.ReadKey();
            }
        }
    }
}
