using System;
using System.Collections.Generic;
namespace TwoSums
{
    class Program
    {

        public static void mergeSort(ref List<int> unsortedArr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2; //grab mid point
                mergeSort(ref unsortedArr, l, m);
                mergeSort(ref unsortedArr, m + 1, r);
                merge(ref unsortedArr, l, m, r);
            }
        }



        public static void merge(ref List<int> unsortedArr, int l, int m, int r)
        {
            int crawler_left = 0;
            int crawler_right = 0;
            int unsortedArr_crawler = l;
            int endOf_algorithm = l;

            //grabbing the left side and right side
            List<int> left_arr = new List<int>(); 
            List<int> right_arr = new List<int>();

            //copy left side
            for (int i = l; i <= m; ++i)
            {
                left_arr.Add(unsortedArr[i]);
            }

            //copy right side
            for (int j = m + 1; j <= r; ++j)
            {
                right_arr.Add(unsortedArr[j]);
            }


            //putting the values in order for this range of the list
            //referencing the new lists that we made, then editing unsortedArr (ref) with the results
            while (crawler_left < left_arr.Count && crawler_right < right_arr.Count)
            {
                if(left_arr[crawler_left] <= right_arr[crawler_right]){
                    unsortedArr[unsortedArr_crawler] = left_arr[crawler_left];
                    ++unsortedArr_crawler;
                    ++crawler_left;
                }
                else
                {
                    unsortedArr[unsortedArr_crawler] = right_arr[crawler_right];
                    ++unsortedArr_crawler;
                    ++crawler_right;
                }
                ++endOf_algorithm;
            }

            //add the rest of the values. 
            //add the left array if all the values on the right side were <
            while(crawler_left < left_arr.Count)
            {
                unsortedArr[endOf_algorithm] = left_arr[crawler_left];
                ++crawler_left;
                ++endOf_algorithm;
            }
            //add the right array if all the values on the left side were <
            while(crawler_right < right_arr.Count)
            {
                unsortedArr[endOf_algorithm] = right_arr[crawler_right];
                ++crawler_right;
                ++endOf_algorithm;
            }

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> list_of_nums = new List<int>();
            List<int> original_nums = new List<int>();
            int[] index_answers = new int[2];

            for (int i = 0; i < nums.Length; ++i)
            {
                list_of_nums.Add(nums[i]); //move the array to a list
                original_nums.Add(nums[i]);
            }

            mergeSort(ref list_of_nums, 0, list_of_nums.Count - 1); //function that will merge sort


            /* to view the output */
            for (int i = 0; i < nums.Length; ++i)
            {
                Console.Write(" " + list_of_nums[i]);
            }




            //now its sorted, find the two sum
            int elem1 = 0;
            int elem2 = 0;
            for (int j = 0; j < list_of_nums.Count; ++j)
            {
                elem1 = list_of_nums[j];
                for (int i = j + 1; i < list_of_nums.Count; ++i)
                {
                    elem2 = list_of_nums[i];
                    if (elem1 + elem2 == target)
                    {
                        index_answers[0] = original_nums.IndexOf(elem1);
                        if(elem1 == elem2) index_answers[1] = original_nums.IndexOf(elem2, index_answers[0]+1); //if they are the same number, check after the first instance
                        else index_answers[1] = original_nums.IndexOf(elem2);
                        return index_answers;
                    }

                }
            }

            index_answers[0] = 0;
            index_answers[1] = 0;
            return index_answers;


        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] test = new int[2] {3,3};


            int[] results = new int[2];
            //TwoSum(int[] nums, int target)
            results = TwoSum(test, 6);

            for(int i = 0; i<results.Length; ++i)
            {
                Console.Write(results[i]);
            }

            Console.ReadKey();
        }
    }
}
