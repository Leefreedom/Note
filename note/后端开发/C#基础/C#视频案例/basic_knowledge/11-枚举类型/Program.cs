using System;

namespace _11_枚举类型
{
    public enum Gender
    {
        男,
        女
    }
    public enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }

    public enum QQstate
    {
        onLine,//0
        offLine,//1
        Leave,//2
        Busy,//3
        QMe,//4
    }
    class Program
    {
        static void Main(string[] args)
        {
            //有点像js中的对象，存数据
            Gender gender = Gender.男;
            Sesons sesons = Sesons.春;
            //Console.WriteLine("我是{0}生,现在是{1}天", gender, sesons);

            #region 枚举类型转为int（默认从0开始，可以自定义设置）
            //Console.WriteLine((int)QQstate.onLine);
            //Console.WriteLine((int)QQstate.offLine);
            //Console.WriteLine((int)QQstate.Leave);
            //Console.WriteLine((int)QQstate.Busy);
            //Console.WriteLine((int)QQstate.QMe);
            #endregion

            #region 将int类型强制转为枚举类型 
            //如果n为QQstate中的对应数，则输出QQstate中的值，否则原值输出
            int n = 10;
            QQstate s1 = (QQstate)n;
            Console.WriteLine(s1);
            #endregion

            #region 将枚举类型转为字符串
            QQstate s = QQstate.onLine;
            Console.WriteLine(s.ToString());
            #endregion

            #region 将字符串转为枚举类型,字符串若是数字，枚举中存在的则显示值，否则就显示数字的字符串类型；若是字符，则必须是枚举中存在的；
            QQstate str1 = (QQstate)Enum.Parse(typeof(QQstate), "11");//offLine
            QQstate str2 = (QQstate)Enum.Parse(typeof(QQstate), "Busy");//Busy
            //Enum.Parse()转为枚举类型的方法
            //参数1为，枚举对象的类型，用typeof可得到
            //参数2为，字符串
            Console.WriteLine("{0},{1}",str1,str2);//offLine,Busy
            #endregion
            Console.ReadKey();
        }
    }
}
