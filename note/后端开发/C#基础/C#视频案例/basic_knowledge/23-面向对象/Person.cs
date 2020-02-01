using System;
using System.Collections.Generic;
using System.Text;

namespace _23_面向对象
{
    //新建的类
    public class Person
    {
        //字段
        string _name;//私有变量只能被内部的方法使用。外部无法使用。
        int _age;//添加了public修饰符后，外部可以访问该变量。
        public char _gender;

        //属性，通过属性来访问私有的字段
        //属性中，只有get为只读属性，只有set为只写属性，都存在Wie可读可写属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            //赋值进行操作
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        public char Gender
        {
            //获取值时进行操作
            get
            {
                if (_gender != '男' || _gender != '女')
                {
                    _gender = '无';
                }
                return _gender;
            }
            set { _gender = value; }
        }


        //方法
        public void GetInfo()
        {
            Console.WriteLine("{0}-----{1}-----{2}", this.Name, this.Age, this.Gender);
            Console.ReadKey();
        }
    }
}