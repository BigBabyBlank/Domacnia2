using System;

namespace Практика
{
    class Russia
    {
        int[] numsGl;
        void Add(int x)
        {

            int[] nums = new int[5] { 1, 2, 3, 4, x };
            numsGl = nums;
        }
        void AddRange(int x, int y)
        {
            int[] nums = new int[] { 1, 2, 3, 4, x, y };
            numsGl = nums;
        }
        void Clear()
        {
            int[] nums = new int[0];
            numsGl = nums;
        }
        void Remove(int x)
        {
            switch(x)
            {
                case 0:
                    int[] nums = new int[0];
                    numsGl = nums;
                    break;
                case 1:
                    int[] nums1 = new int[1] { 1 }; 
                    numsGl = nums1;
                    break;
                case 2:
                    int[] nums2 = new int[2] { 1, 2 };
                    numsGl = nums2;
                    break;
                case 3:
                    int[] nums3 = new int[3] { 1, 2, 3 };
                    numsGl = nums3;
                    break;
                default:
                     int[] nums4 = new int[] { 1, 2, 3, 4 };
                    numsGl = nums4;
                    break;
            }
        }
        void RemoveAt(int x)
        {
            switch(x)
            {
                case 0:
                    int[] nums = new int[] { 2, 3, 4 };
                    numsGl = nums;
                    break;
                case 1:
                    int[] nums1 = new int[] {1,3,4};
                    numsGl = nums1;
                    break;
                case 2:
                    int[] nums2 = new int[] {1,2,4 };
                    numsGl = nums2;
                    break;
                case 3:
                    int[] nums3 = new int[] { 1,2,3};
                    numsGl = nums3;
                    break;
                default:
                    int[] nums4 = new int[] { 1, 2, 3, 4 };
                    numsGl = nums4;
                    break;
            }
        }
        void Contains (int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine(true);
                    break;
                case 2:
                    Console.WriteLine(true);
                    break;
                case 3:
                    Console.WriteLine(true);
                    break;
                case 4:
                    Console.WriteLine(true);
                    break;
                default:
                    Console.WriteLine(false);
                    break;
            }
        }
        void Insert(int x,int y)
        {
            switch (x)
            {
                case 0:
                    int[] nums = new int[] {y,1, 2, 3, 4 };
                    numsGl = nums;
                    break;
                case 1:
                    int[] nums1 = new int[] { 1, y, 2, 3, 4 };
                    numsGl = nums1;
                    break;
                case 2:
                    int[] nums2 = new int[] { 1, 2, y, 3, 4 };
                    numsGl = nums2;
                    break;
                case 3:
                    int[] nums3 = new int[] { 1, 2, 3, y, 4 };
                    numsGl = nums3;
                    break;
                default:
                    int[] nums4 = new int[] { 1, 2, 3, 4,y };
                    numsGl = nums4;
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
