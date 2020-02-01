using System;

namespace _12_结构类型
{
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 10;
            zsPerson._gender = Gender.男;

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 20;
            lsPerson._gender = Gender.女;
            Console.WriteLine(lsPerson._name);
            Console.ReadKey();
        }
    }
}
