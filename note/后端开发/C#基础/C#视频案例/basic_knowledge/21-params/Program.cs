using System;

namespace _21_params
{
    class Program
    {
        static void Main(string[] args)
        {
            GetScore("张三",100,14,23);
            Console.ReadKey();
        }
        //params
        //只能给最后一个参数添加
        //下列的意思为：第二个参数到最后一个参数都为score数组中的值，但是参数类型必须为int
        public static void GetScore(string name, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}今年的考试总成绩为{1}", name, sum);
        }
    }
}
