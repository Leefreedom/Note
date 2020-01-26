/*
  边框
    1、盒子边框border：border-width border-style border-color
    2、盒子圆角边框border-radius：
    3、table的边框合并：border-collapse：collapse
*/

/*
  内边距
    写法：
      1、padding：上 右 下 左 或者 上 左右 下
    注意：
      1、padding会撑开带有width和height的盒子，不会撑开没有显式设定高宽的盒子。
*/


/*
  外边距
    用法：margin:0 auto;
      1、必须是块级元素
      2、盒子必须指定了宽度
      然后给左右外边距设为auto，就可使块级元素居中。
*/

/*
  问题：当父盒子中嵌套了子盒子，我们使用margin-top外边距无法将子盒子下移
  解决办法：
    1、父盒子使用overflow:hidden
    2、父盒子设置边框
*/



/*
  盒子阴影
    box-shadow：水平阴影 垂直阴影 模糊距离(虚实) 阴影尺寸(阴影大小) 阴影颜色 内外阴影
*/