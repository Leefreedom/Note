using System;
using System.Collections.Generic;
using System.Text;

namespace _24_构造函数
{
    public class Student
    {
        //字段
        string _name;
        int _age;
        char _gender;
        double _chinese;
        double _math;
        double _english;
        //属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public double Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        public double Math
        {
            get { return _math; }
            set { _math = value; }
        }
        public double English
        {
            get { return _english; }
            set { _english = value; }
        }

        //方法
        public void ShowStudent()
        {
            Console.WriteLine("我叫{0}，我今年{1}，我是一名{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("{0},语文{1},数学{2},英语{3}", this.Name, this.Chinese, this.Math, this.English);
        }
        //构造函数
        public Student(string name, int age, char gender, double chinese, double math, double english)
        {
            this.Name = name;
            if (age<0|| age>100)
            {
                age = 0;
            }
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
    }
}
