using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] nums = new int[number];
            for (int i = 0; i < number; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
