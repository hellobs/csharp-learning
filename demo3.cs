using System;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
/*             Console.WriteLine("今天是几月?");
            int month=int.Parse(Console.ReadLine());
            
            switch (month)
            {
                case 3:
                    Console.WriteLine("春天到了");
                    break;
                case 6:
                    Console.WriteLine("夏天到了");
                    break;
                case 9:
                    Console.WriteLine("秋天到了");
                    break;
                case 12:
                    Console.WriteLine("冬天到了");
                    break;               
                default:
                    Console.WriteLine("Happy");
                    break;
            } */


/*          long res=0;
            for (int i = 1; i <= 9997; i += 3)
            {
                res+=i;
            }
            Console.WriteLine(res);*/
            
/*          double asave=365*20;
            double total=asave;
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("第{0}年的本金:{1},",i,total);
                double income=total*0.1; //上年的利息
                
                Console.Write("第{0}年的收益：{1},",i,income);
                Console.Write("本息总计：{1}\n",i,income+total);
                total = total*1.1+asave;
            } */
/* 
            long res=0;
            long daily_m=1;
            for (int i = 0; i < 30; i++)
            {
                res+=daily_m;
                daily_m*=2;
            }
            Console.WriteLine(res); */


/*             for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}x{1}={2};",j,i,j*i);
                }
                Console.Write("\n");
            }  */

            double h=0.0002f;
            int cnt=0;
            while (h <= 8844.43f)
            {
                h*=2;
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}