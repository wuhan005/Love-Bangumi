# Love Bangumi 一个可以让你可以更加科学地补番的软件

A software which can be used to watch bangumi more comfortably.[![GitHub license](https://img.shields.io/badge/license-GPLv2-blue.svg)](https://raw.githubusercontent.com/wuhan005/Love-Bangumi/master/LICENSE)
<br />

[![AppVeyor](https://img.shields.io/appveyor/ci/wuhan005/Love-Bangumi/master.svg)](https://ci.appveyor.com/project/wuhan005/love-bangumi/)    

作者我是B站鬼畜区UP主。之前在逛B站时偶然发现了B站的各类API，功能还挺全的。<br />
接着便想可否做点有意思的东西... 然后就有了这个玩意。<br />
之后我便希望能有一个软件可以让我快速的找到自己喜欢的番剧，并且还能迅速找到那部番的高清壁纸啊/OST之类的资源，甚至是可以直接看到大家对这部番的讨论与评价。<br />
[官网主页](https://wuhan5.cc/love-bangumi/)<br />

## 功能 Features

 - [X] 拉取用户在B站订阅的番剧并排版 ![Progress](http://progressed.io/bar/90?title=completed)
 - [X] 从 QQ音乐API 获取番剧音乐 ![Progress](http://progressed.io/bar/85?title=developing)
 - [ ] 软件内播放番剧
 - [X ] 从Pixiv搜索番剧的同人图 ![Progress](http://progressed.io/bar/65?title=developing)
 - [ ] 从贴吧/知乎拉取番剧的用户讨论

## 启动 Startup

Clone from Github<br />

    git clone git@github.com:wuhan005/Love-Bangumi.git

在`getBiliBangumi.cs`中，将`biliID`常量的值改为你的Bilibili ID，即可从你的Bilibili空间拉取番剧数据。<br />
注意：Bilibili个人空间番剧信息应设置为公开状态。

## 更改日志 Change Log
### v0.0.4 ( 2017/5/21 14:53 )
* 引入pixiv API
### v0.0.3（2017/4/16 15:02）
* 加入 Music Hunter 从 QQ音乐API 拉取番剧音乐
### v0.0.2（2017/4/12 16:43）
* 修复了番剧详细页分集图片显示错误的问题
### v0.0.1（2017/4/12 14:00）
* 撰写README.md
* 将Love-Bangumi部署到了Github上

## 贡献 Contribution
QQ音乐API（PHP ver.）[metowolf/TencentMusicApi](https://github.com/metowolf/TencentMusicApi)<br />
[Pixiv API](https://api.imjad.cn/pixiv/index.html)<br />



## 联系我 About Me
E-mail：524306184@qq.com<br />
个人博客：[点击链接](https://wuhan5.cc/)<br />
QQ：524306184<br />

