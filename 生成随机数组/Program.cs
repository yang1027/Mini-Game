using System;

namespace 生成随机数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"生成一个元素从小到大的随机数组：");

            int Length = 10;
            int[] array = new int[Length];
            array[0] = 5;
            Console.Write(array[0] + " ");

            for (int i = 1; i < Length; i++)
            {
                array[i] = array[i - 1] + new Random().Next(1,5);

                Console.Write(array[i]+" ");

                Console.WriteLine(new Random().Next(1, 5));

            }


        }
    }
}
