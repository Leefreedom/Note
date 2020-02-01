using System;
using System.Diagnostics;
using System.Text;

namespace _27_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //Append追加
            /*string str = "";//如果使用字符串，相当于在内存中开辟了1000000个空间
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                //str += i;
                sb.Append(i);//在字符串的后面追加,只会开辟一个内存空间
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);*/

            //字符串用索引访问，返回一个char类型,能访问，无法改变
            string str = "abcdefg";
            Console.WriteLine(str[1]);//b

            char[] strArr = str.ToCharArray();//将字符串转换成char类型的数组
            strArr[0] = 'b';//在改变

            str = new string(strArr);//在将char数组变为字符串
            Console.WriteLine(str);//bbcdefg

            str=str.ToUpper();//大写
            Console.WriteLine(str);//BBCDEFG
            str = str.ToLower();//小写
            Console.WriteLine(str);//bbcdefg

            str=str.Substring(2);//一个参数就是开始位置到最后，两个参数是两个之间,不包括第一个参数
            Console.WriteLine(str);//cdefg

            string lessonOne = "C#";
            string lessonTwo = "c#";
            //比较字符串是否相同，第二个参数是忽略大小写
            if(lessonOne.Equals(lessonTwo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("两个字符串相同");
            }
            else
            {
                Console.WriteLine("两个字符串不相同");
            }

            string pos = "浙江省，温州市";
            string[] posArr=pos.Split("，");
            Console.WriteLine("{0}", posArr[0]);

            string time = "2020  ---,  --,--  1,---  -- -30";
            char[] chas = { '-', ',', ' ' };
            //后面可以跟字符串切割的配置参数
            string[] timeNew = time.Split(chas,StringSplitOptions.RemoveEmptyEntries);//{2020,1,30}


            string season = "春夏秋冬";
            string newSeason=season.Replace('秋','哈');

            Console.WriteLine("{0}", newSeason);

            Console.ReadKey();
        }
    }
}
