using System;

namespace _24_构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三",20,'男',98,88,78);
            zsStudent.ShowStudent();
            zsStudent.ShowScore();
            Console.ReadKey();
        }
    }
}
