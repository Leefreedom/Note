/*
  常见PC浏览器：
        1.谷歌chrom(最常用)
        2.火狐Firefox
        3.IE
        4.safari
        5.opera

  浏览器内核主要分为<渲染引擎>、<js引擎>两部分,通常说的内核为渲染引擎。
 */

/*    *********推荐谷歌chrom**********
  1.谷歌浏览器chrom
        - 内核：Chromium/Blink，在webkit的基础上二次开发。
                在Chromium项目中研发Blink渲染引擎，内置在chrom浏览器中，Blink其实就是webkit的分支。
                大部分国产浏览器的最新版都使用了《Blink内核》

  2.火狐Firefox
        - 内核：Gecko
                Gecko的特点是代码开源，开发程度高。（近几年落寞）

  3.IE
        - 内核：Trident
                国内大多数的双核浏览器中的一核即为IE内核Trident，美名为“兼容模式”。
                大多数浏览器包括：IE,遨游,世界之窗,猎豹浏览器,360极速浏览器,百度浏览器...
        - 新内核：EdgeHTML
                window10发布后，IE内置浏览器更名为Edge，最显著的特定是使用了新内核EdgeHTML。

  4.safari（苹果公司）
        - 内核：webkit*******重点内核，webkit是由苹果公司出品的。

  5.opera
        - 内核：Presto（已经废弃）
                  Presto是挪威浏览器opera的"前任"内核，现在的opera已经投入了谷歌的怀抱。
*/



/*
  常见移动端浏览器(主要是系统内置浏览器)：
        1.Android：使用率最高的是webkit内核，大部分国产宣称是自己开发的内核，实则就是webkit的二次开发。
        2.iOS以及WP7(windows开发的手机系统)：这些系统都会自带浏览器内核，一般是《safari的内核》或者《IE的内核》
*/



/*
      浏览器内核的不同，工作原理，解析不同，显示就会存在差异。【俗称的兼容性问题】

      为此我们需要制定统一的标准---------web标准

      web标准由----结构(html)、样式(css)、行为(JavaScript)
*/