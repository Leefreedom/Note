using System;
using System.Collections.Generic;
using System.Text;

namespace _25_静态和非静态
{
    //静态类
    public static class Student
    {
        static string _name;
        static int _age;

        public static string Name { get => _name; set => _name = value; }
        public static int Age { get => _age; set => _age = value; }

        public static void ShowStudent()
        {
            Console.WriteLine("我叫{0},今年{1},是一名学生", Name, Age);
        }
    }
}
