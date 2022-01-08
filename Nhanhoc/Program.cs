using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num% 2== 0)
            {
                if (num%3 == 0)
                {
                    Console.WriteLine($"So {num} la so chan va chia het cho 3");
                }
                else
                {
                    Console.WriteLine($"So {num} la so chan va khong chia het cho 3");
                }
            }
            else
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine($"So {num} la so le va chia het cho 3");
                }
                else
                {
                    Console.WriteLine($"So {num} la so le va khong chia het cho 3");
                }
            }
        }
    }
}