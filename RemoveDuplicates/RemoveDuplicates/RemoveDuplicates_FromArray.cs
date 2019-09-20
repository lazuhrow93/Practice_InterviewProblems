using System;

namespace RemoveDuplicates
{
    class RemoveDuplicates_FromArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] list_of_nums2 = new int[3] { 1, 1, 2 };
            int[] list_of_nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            int unique_length = 1;
            bool changed = false;
            int curr_num = list_of_nums[0];


            for (int i = 1; i < list_of_nums.Length; ++i)
            {
                if(list_of_nums[i] != curr_num)
                {
                    ++unique_length;
                    curr_num = list_of_nums[i];
                }
            }


            Console.WriteLine("LENGTH: " + unique_length);
            Console.ReadKey();

        }
    }
}
