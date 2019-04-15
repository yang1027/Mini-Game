using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int max = 1000;
            int random = new Random().Next(max);
            bool success = false;
            Console.WriteLine($"请输入一个不超过{max}的自然数");
            for (int i = 0; i < 10; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int reducetimes = 9 - i;
                if (input > random)
                {
                    Console.WriteLine($"太大了哟！（还剩{reducetimes}次）");
                }
                else if (input < random)
                {

                    Console.WriteLine($"太小了哟！（还剩{reducetimes}次）");
                }
                else
                {
                    success = true;
                    Console.WriteLine($"恭喜你答对了哟！只用了{i + 1}次呢，你真厉害！");
                    break;

                }

            }
                if (!success )
                {
                    Console.WriteLine($"真可惜没有猜到哦！正确答案是："+random );
                }
               

            
       








        }
    }
}
