using System;

namespace 二分查找法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[] {15,27,56,79,101,235,458,642,897,943 };
            Console.WriteLine($"现有数组：15,27,56,79,101,235,458,642,897,943 ");
            int max = array.Length - 1;
            int min = 0;
            int current = 0;
            Console.WriteLine($"请输入想要查找的数：");

            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <array.Length ; i++)

            {
                if (input == array[current])
                {
                    Console.WriteLine($"找到了，共查找了{i}次，所查找数字在第{current + 1}位");
                    break;

                }
                else
                {
                    Console.WriteLine($"第{i}此查找，取{array[current]}进行比较");

                    if (input > array[current])
                    {
                        min = current;
                        int steps = (max - min) / 2;

                        Console.WriteLine($"要查找的值{array[current]}<{input},向右移动{steps}位进行下一次查找");
                        current = current + steps;
                    }
                    else
                    { 
                        max = current;
                        int steps = (max - min) / 2;
                        Console.WriteLine($"要查找的值{array[current]}>{input},向左移动{steps}位进行下一次查找");
                        current = current - steps;
                    }
                    Console.WriteLine($"下一次进行比较查找到数为{array[current]}");
                }

                
            }

            Console.Read();

                

        }
    }
}
