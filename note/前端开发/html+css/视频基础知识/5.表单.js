/*
  表单：收集用户的数据。
    1.表单控件：具备表单的功能，输入框，单选框，复选框，文本域，提交按钮，重置按钮。
    2.提示信息：表单中还需要包含一些提示性的文字说明。
    3.表单域：容纳所有表单控件和表单信息，通过它定义处理表单数据。例如url地址。
*/

/*
  input：输入框，单标签。
    属性列表：
      1.type:{
          text：单行文本输入框
          password：密码输入框
          radio：单选按钮
          checkbox：复选框
          button：普通按钮
          submit：提交按钮
          reset：重置按钮
          images：图像形式的提交按钮
          file：文件域
      }
      2.name：控件名称
      3.value：默认文本值
      4.size：显示宽度
      5.checked：当type为checkbox或radio时，默认选中的项
      6.maxlength：控件允许输入的最多字符数
*/
/*
      radio：如果单选框为一组，设置相同的name属性值，便可以多个选择其中一个。
      label：用户绑定一个表单元素，for属性中属性值为表单元素的id属性值。
*/


/*
      textarea：多行文本输入框
        1.cols：列数
        2.rows：行数
*/

/*
      select：下拉菜单
      option：下拉菜单选项标签

      [注意]：可在option中的selected属性中设置默认项。
*/


/*
      表单域:
        1.action：提交到后台的地址
        2.method：提交方式，post或get
        3.name：区别同一个页面多个表单域
*/