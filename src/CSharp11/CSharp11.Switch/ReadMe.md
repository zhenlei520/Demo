### 新列表模式

``` C#
public static int MatchExp(int[] array)
{
    return array switch
    {
        [] => 1, //匹配一个空列表
        [_, .. , 2] => 2,//匹配一个长度大于等于2的列表，切最后的一位元素为2，返回2
        [_, int second] => second + 1, // 匹配一个长度为2的列表，并且返回第二个元素 + 1
        [_, .. int[] middle, _, _] => middle.Sum(), //匹配从下表为1开始的元素到倒数第二个元素截止的元素集合，并返回集合之和
        _ => -1, // 匹配其他情况时返回-1
    };
}
```

``` C#
var array = new[] { 1, 2, 3, 4, 5, 6 };
var res = SpeedComp.MatchExp(array);
Console.WriteLine("result: " + res); // 2+3+4=9
```