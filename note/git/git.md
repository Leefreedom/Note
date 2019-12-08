# git

## 版本控制系统(简介)
> 用处
- 版本存储
- 备份版本
- 历史版本
- 多人开发

> 类型
- 分布式版本控制系统(git)
- 集中式版本控制系统(svn)

> 两者区别[面试题]:
1. 集中式：
- 所有的历史版本都存在中央服务器中。
- 想要做历史记录的查看和备份，必须链接到中央服务器（需要联网）
- 处理速度没有git快
2. 分布式：
- 每个开发者本地都是一个单独的仓库(云端仓库的镜像)。
- 在自己的仓库中就可以完整历史版本的记录和查看（不需要联网）
- git的处理速度更快（git是按照数据存储的）

## git的安装
> window，Linux，Mac

## git的基本命令(本地)
> 初始化仓库
- 命令：`git init`
- 会在目录中生成一个隐藏的.git文件夹，里面存放着项目代码的不同版本

> 配置个人信息
- 用处：每次提交到github、码云或远程服务器时,该信息为提交者的信息。
- 设置名字命令：`git config --global user.name "名称"`
- 设置邮箱命令：`git config --global user.email "邮箱"`

> 把代码放入git仓库
- 提交到暂存区：`git add 文件路径` 或 `git add ./`
- 将暂存区的文件放入本地仓库：`git commit -m "描述说明"`
- 一次性将我们修改过的文件放入到本地仓库中：`git commit --all -m "描述说明"`

> 查看暂存区的内容
- 命令：`git status`

> 查看历史提交的日志
 - 输入命令：`git log`
 - 输入命令：`git log --oneline` 简洁版的日志
> 版本回退
 - 输入命令：`git reset --hard Head~0`  0为索引向前推几个版本。0为向前一个版本。
 - 输入命令：`git reset --hard 版本号`  回退到指定的版本
> 版本切换记录
 - 输入命令：`git reflog`

> 分支
 1. 新建分支 
 - 创建了一个dev分支： `git branch dev`
 - 在刚创建时dev分支里的东西跟主分支master里的东西是一样的。
2. 查看当前所有分支：`git branch`

 3. 切换分支
 - 切换到dev分支：`git checkout dev`

4. 合并分支
 - 合并分支内容：`git merge dev`
 - 把当前分支与指定分支(dev)进行合并
 - 当前分支指的是 `git branch` 命令输出的带有*号的分支。
 # 远程仓库使用
 > 连接github
- git连接到github：`ssh-keygen -t rsa -C "自己的邮箱地址"`,得到密匙后，复制id_rsa.pub中所有字符，添加到github的SSH中。
- 关联某个存储库：`git remote add origin git@gitee.com:xxxx/xxxx.git`,其中的`origin`是我们自定义的远程库名称，默认`origin`。
- 如果使用`git remote add`报错,说明本地库已经关联了一个远端的git仓库，可以先用`git remote -v`查看远程库信息,可以删除`git remote rm origin`,在关联新的远端库。
- 检查是否连接上github：`ssh -T git@github.com`
> 同时关联2个远程仓库[码云，github]
- git remote add github git@github.com:xxx/xxx.git
- git remote add gitee git@gitee.com:xxx/xxx.git
- 注意两个远程库的名称为：github，gitee。
- 推送到github：`git push github master`
- 推送到gitee：`git push gitee master`
> 推送和下拉
- 将远程库拉到本地：`git pull [地址]` 或 `git clone [地址]`
