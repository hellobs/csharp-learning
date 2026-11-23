using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Principal;
namespace hello
{
    class Program
    {
        static int max(int a,int b) {return (a>b)?a:b;}
        static void Main(string[] args)
        {
            /*
            int a=5;
            int b=2;
            double res=(double)a/(double)b;
            double r_res=(int)(res+0.5f); 
            Console.WriteLine(r_res); */

/*          Console.WriteLine("请输入第一个浮点数");
            float ftemp1=float.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个浮点数");
            float ftemp2=float.Parse(Console.ReadLine());
            Console.WriteLine("最大的浮点数是:{0}",Math.Max(ftemp1,ftemp2));

            //逻辑练习
            if ((ftemp1>0) && (ftemp2>0)) Console.WriteLine("全是正数"); else Console.WriteLine("不全是正数"); */

            //max(max(a,b),c)
/*             int a,b,c;
            a=1;b=3;c=2;
            int t1=max(a,b);
            int t2=max(t1,c);
            Console.WriteLine(t2);

            //使用冒泡排序(n^2)/快速排序(nlogn)
            int[] arr = new int[1000];
            arr[0]=1;arr[1]=3;arr[2]=2;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3- 1 - i; j++)
                {
                    if (arr[j] < arr[j+1])
                    {
                        int temp=arr[j+1];  //swap
                        arr[j+1]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
            Console.WriteLine(arr[0]); */

            if (1){
                1;
            }else if(2){
                2;
            }else if (3){
                3;
            }else {
                4;
            }

        }
    }
}