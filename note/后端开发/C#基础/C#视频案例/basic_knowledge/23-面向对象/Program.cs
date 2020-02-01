using System;

namespace _23_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //类==> 对象
            //类是一个模板，确定一个对象拥有的属性和方法
            Person zsPerson = new Person();//实例化对象
            Person lsPerson = new Person();
            zsPerson.Age = 120;
            zsPerson.Gender = 'h';
            zsPerson.Name="张三";//属性来访问私有变量
            zsPerson.GetInfo();
        }
    }
}
