using System;

namespace _09_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = 10;
            int i;
            for (i = 0; i < num; i++)
            {
                if (i == 2)
                {
                    //break; 跳出循环
                    //continue;跳过此次循环
                }
                Console.WriteLine("hello world,i={0}", i);
            }
            
            Console.WriteLine("i={0}", i);//10*/

            //九九乘法表
            /*int num = 10;
            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);

                }
                Console.WriteLine();//换行
            }*/

            Console.WriteLine("请输入数字");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}+{1}={2}\t", i, num - i, num);
            }
            Console.ReadKey();


            for (int k =10 ; k >= 0; k--)
            {
                //递减
            }
        }
    }
}
