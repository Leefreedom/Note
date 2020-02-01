using System;
using System.Collections.Generic;
using System.Text;

namespace _25_静态和非静态
{
    //非静态类
    public class Teacher
    {
        string _name;
        static int _age;//非静态类中是可以出现静态成员的。
        public string Name { get => _name; set => _name = value; }
        public static int Age { get => _age; set => _age = value; }

        public void ShowTeacher()
        {
            Console.WriteLine("我叫{0},今年{1},是一名老师", this.Name, Teacher.Age);
        }
    }
}
