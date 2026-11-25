using System;
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1=new int[10]{1,2,3,5,4,6,7,8,9,0};
            for (int i=0;i<arr1.Length;i++) Console.Write(arr1[i]);Console.Write('\n');
            Array.Sort(arr1);
            for (int i=0;i<arr1.Length;i++) Console.Write(arr1[i]);Console.Write('\n');
            Array.Reverse(arr1);
            for (int i=0;i<arr1.Length;i++) Console.Write(arr1[i]);Console.Write('\n');

            string[] names = new string[3]{"A","B","C"};

            string position=Console.ReadLine();
            
        }
    }
}