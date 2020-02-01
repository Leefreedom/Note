using System;

namespace _25_静态和非静态
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态类相关
            //Student s = new Student();静态类无法实例化对象
            Student.Name = "静态";
            Student.Age = 200;
            Student.ShowStudent();

            //非静态类相关
            Teacher t = new Teacher();
            t.Name = "非静态";//非静态成员用实例化对象调用
            Teacher.Age = 100;//静态成员用类对象调用
            t.ShowTeacher();

            Console.ReadKey();
        }
    }
}
