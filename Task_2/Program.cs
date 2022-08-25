using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    internal class Program
    {
        public static int[] Duplkiller(int[] sortedArr)
        {
            List<int> temp = new List<int>();
            for (int i=0; i<sortedArr.Length; i++)
            {
                if (!temp.Contains(sortedArr[i]))
                    temp.Add(sortedArr[i]);
                else continue;
            }
            int[] result = new int[temp.Count];
                return result = temp.ToArray();
        }

        static void Main(string[] args)
        {
            int[] sortedArr = new int[] {1,2,3,4,4,56};
            foreach (var i in Duplkiller(sortedArr))
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
