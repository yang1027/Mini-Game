using System;

namespace learning4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[] { 6, 15, 54, 79, 105, 187, 249, 356, 498, 512 };
            Console.WriteLine($"现有数组 ：6, 15, 54, 79, 105, 187, 249, 356, 498, 512");

            int index = array.Length - 1;
            Console.WriteLine($"请输入想要查找的数：");
            int input = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= array.Length; i++) 
            {
                int steps = (index + 1) / 2;
                if (input == array[index])
                {
                    Console.WriteLine();
                    Console.WriteLine($"找到了！共查找了{i}次，位置就在{index + 1}位");
                    break;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"第{i}次查找，取第{index+1}位，值为{array[index]}");
                    if (input > array[index])
                    {
                        index += steps;//index=index+stpes
                    }

                    else
                    {
                        index -= steps;
                    }

                    Console.WriteLine($"设下一次查找位置为{index+1}位");

                    Console.WriteLine();
                    //这个有bug找不到第9位数字
                }








            }

            Console.ReadLine();
                                
        }

    }
}
