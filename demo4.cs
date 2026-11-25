using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
namespace hello
{
    class Program
    {
        /*      
        static int find(string s, int pos) //递归
        {
            int idx = s.IndexOf("12", pos);
            if (idx == -1) return 0;
            else Console.WriteLine("出现的索引:{0}",idx);              
            return 1 + find(s, idx + 2);          
        } */
        static void Main(string[] args)
        {
/*          string s="hello!";
            Console.WriteLine(s.Length); 

            bool isin = s.Contains("ll");
            if(isin==true) Console.WriteLine("这个字符串包含ll");
            int pix=s.IndexOf("e");
            Console.WriteLine(pix); */
            //string s="1454593212344949235696453420322";  //只有一个12
/*          int cnt=0;
            int pos=0;
            while (true)
            {
                pos=s.IndexOf("12",pos);   //不断更新pos，往下滚动
                if (pos==-1) break;        //终止条件
                else                       //
                {
                    cnt++;
                    pos+=2;
                }
            }
            Console.WriteLine(cnt); */
/*          string s="145459321234494923569645342032211285992312211343949";
            int cnt2=find(s,0);
            Console.WriteLine(cnt2);
        }
 */
/*      string number="440306200612090713";
        int pos=number.Length-12;
        string date=number.Substring(pos,8);
        Console.WriteLine(date); */

        //练习1
        string number=Console.ReadLine();
        bool s1=(number.Length==11);
        bool s2=true;
        for(int i = 0; i < number.Length; i++)
            {
                if (!('0'<=number[i] && number[i]<= '9')){
                    s2=false;
                    break;
                }
            }
        bool s3=(number[0]!='0');
        if (s1 && s2 && s3) Console.WriteLine("有效");
        else Console.WriteLine("无效,无效位对应为{0},{1},{2}",s1,s2,s3);

        //练习3
        string raw=Console.ReadLine();
        raw=raw.Substring(1,raw.Length-2); //删除外侧括号
        while (raw.Contains(','))
            {
                int pos=raw.IndexOf(',');
                Console.WriteLine(raw.Substring(0,pos));
                raw=raw.Substring(pos+1);            
            }
        Console.WriteLine(raw);  //最后只剩下一个数也要输出
        }
    }
}