# Linux常有命令
> 特别注意：linux命令和window doc命令类似，但是并不是相同的命令，（linux和window是不同的两个系统），git bash中使用的是linux命令。

> 常用基础命令
 - ls 查看当前目录下的文件（夹）
   + ls -l 查看详细信息
   + ls -a 查看隐藏的信息
   + ls -la 同时具备以上2个特征

 - cd 目录切换
   + cd ../ 返回上级目录
   + cd ./ 返回当前目录
   + cd / 返回根目录
   + cd xxx 进入到指定文件夹
   + cd E: 进入到指定磁盘
 - mkdir xxx 创建文件夹
 
 - touch xxx.xx 创建文件
   + 允许创建（类似于.babelrc),无文件名、只有后缀名的文件
   + 在电脑隐藏后缀名时，我们不至于创建出类似于 a.txt.txt重复后缀的文件。

- vi 向指定的文件中插入内容
  + 首先进入命令窗口模式
  + i 进入插入模式，编辑需要写入的内容
  + esc 在按:键，wq为强制保存退出
  + q！ 强制退出，新输入的内容不保存

- echo xxx > 1.txt 把内容xxx放入1.txt，文件不存在，自动创建；文件存在，覆盖内容。
  + echo xxx >> 1.txt 把内容xxx放入1.txt，不覆盖内容。

- cat 查看文件内容

- cp 拷贝文件  cp a.txt b.txt 拷贝a.txt内容到b.txt

- rm 删除文件
  + -r 递归删除（把当前文件夹中所有的后代遍历删除）
  + -f 强制删除
  + -rf 强制删除，文件夹和文件夹内的元素，无法还原。

  
