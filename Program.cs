using System;
using System.Diagnostics;

struct MyStruct
{
    public int Val1;
}
class A1
{
    public int Val1 = 0;
}
class Programs
{
    static void Main(String[] args)
    {
        const int max = 1000000;
        Stopwatch sw = new Stopwatch();
        MyStruct[] obj1 = new MyStruct[max];
        sw.Start();
        for (int i = 0; i < max; i++)
        {
            obj1[i] = new MyStruct();
            obj1[i].Val1 = i;

        }
        sw.Stop();
        Console.WriteLine("構造体の場合:{0}ミリ秒", sw.ElapsedMilliseconds);

        A1[] obj2 = new A1[max];
        sw.Reset();
        sw.Start();
        for (int i = 0; i < max; i++)
        {
            obj2[i] = new A1();
            obj2[i].Val1 = i;
        }
        sw.Stop();
        Console.WriteLine("クラスの場合：{0}ミリ秒", sw.ElapsedMilliseconds);
    }
}
