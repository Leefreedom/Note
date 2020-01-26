/*
  C#的基本变量类型
    1、int：表示整数，只能存放整数。
    2、double：表示小数类型，既能存储小数，也可以存储整数。
    3、string：能够存储多个文本，可以为空。【双引号】
    4、char：字符类型，能够存储单一的字符，要求最多最少只能存储一个字符，不能为空。【单引号】
    5、decimal：金钱类型，精度高于double。
*注意*：变量不允许重复声明。

*/

/*
  命名规则
    1、必须以“字母”，下划线“_”，或“@”符开头，不能以数字开头。
    2、后面可以跟任意“字母”，“数字”，“下划线”。
    3、变量名不能跟C#中的关键字重名。
    4、C#中大小写敏感。
    5、同一个变量名不能重复声明。
    6、命名使用驼峰命名法
*/

/*
  运算符
    1、=：赋值符号
    2、+：字符串拼接，数值计算。
    3、占位符
      Console.WriteLine("第一个数字{0}，第二个数字{1}，第三个数字{2}", numOne, numTwo, numThree);
      将后面的三个参数依次填入{0},{1},{2}
    4、转义字符"\"：
          1、换行：\r\n
          2、删除前个字：\b,放在字符串的两端无效果。
          3、tab键：\t
          4、在字符串的前面引号外部添加 "@" 可以让字符串中的所有字符保持单纯的字符。
    5、算数运算符
      1、+、-、*、/、% ：加、减、乘、除、取余
*/

/*
  自动类型转换(隐式类型转换)
    1、类型必须兼容(int和double)
    2、必须是小类型转大类型
  强制类型转换
    1、大类型转小类型

  超强类型转换(convert)
    1、convert对象方法含有很多强制转换的类型方法
      - 什么使用使用呢？
        - 当两种类型不兼容时，而且值上面要符合转换后的类型，否则不成功就报错。
*/