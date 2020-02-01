using System;
using _25_静态和非静态;
namespace _26_访问外部项目的类
{
    class Program
    {
        static void Main(string[] args)
        {
            //右键依赖添加引用，选择其他项目，然后在本项目上方using引入
            Teacher t = new Teacher();
            t.Name = "引用";
            Teacher.Age = 100;
            t.ShowTeacher();
            Console.ReadKey();
        }
    }
}
