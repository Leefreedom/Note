using System;

namespace _18_out参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，判断用户是否登录成功
            //如果登陆成功返回true，并且返回登录信息
            bool IsLogin;
            string LoginMessage = null;
            Console.WriteLine("请输入用户名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            Login(out IsLogin, out LoginMessage, username, pwd);
            Console.WriteLine("{0}",LoginMessage);
            Console.ReadKey();
        }

        public static void Login(out bool b,out string message,string username,string pwd)
        {
            bool login = username == "admin" && pwd == "123" ? true : false;
            b = login ? true : false;
            message = login ? "登录成功" : "登录失败";
        }
    }
}
