using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        // Verilmis ededler siyahisindan yalniz musbet ededler qalan yeni bir siyahi duzelden metod
        {
            int[] num = { -56, -666, -2324, 23443, -2243, 432 };
            int[] newnum = positive(num);
            for(int i=0;i<num.Length;i++)
            {
                Console.WriteLine(newnum[i]);
            }
        }
        static int[] positive(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] > 0)
                result[i] = nums[i];
            }
            return result;
        }
        
        
    }
}
