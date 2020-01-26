/*
    浮动特性：float
      1、给一个元素设置浮动，他后面的元素会有影响，但是他前面的不会有影响。
      2、浮动默认会将元素转换为行内块元素。
*/


/*
  清除浮动方法
    1、额外标签法
        - 在浮动元素的末尾添加一个空标签，并设置css为clear:both;
        - 缺点：增加许多无意义的标签，结构化差。
    2、父级元素添加overflow：hidden
    3、使用after伪元素清除浮动
        - .clearfix:after{
              content:"";
              height:0;
              display:block;
              clear:both;
              visibility:hidden;
          }
        - IE6清除浮动的方式 .clearfix{*zoom:1} //*号，IE6、7识别，其他浏览器略过。
    4、使用before和after双伪元素清除浮动
        - .clearfix:after,.clearfix:before{
              content:"";
              display:table;
          }
          .clearfix:after{
            clear:both;
          }
          .clearfix{*zoom:1}
*/
