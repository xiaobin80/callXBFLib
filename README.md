# callXBFLib
Calling the XBF Library(xbfInfo.dll).

- IDE    
  VS2008
- Lang    
  C Sharp

## Files List

### Cwin32API.cs
封装win32函数

- Cwin32API(string fileName)    
  默认构造函数；    
  参数为ini文件(全路径: 路径+文件名)
     
- GetPrivateProfileString    
  读取配置文件（ini）中指定块中的键值。    
     
- readIniFileVal(string section, string key)    
  读Ini文件中键值    
  参数：section - 块    
```
    key - 键
```

### Form1.cs
  实现2按钮事件；    
  以及在窗体构造事件里添加类实例代码，例如：    
```c#
  ini = new Cwin32API(currDir + "/xbfConfig.ini");
```
