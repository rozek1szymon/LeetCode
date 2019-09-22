using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Zeros
{

    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            bool foundzero = false;
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 0)
                {
                    numbers.Enqueue(arr[i]);
                    foundzero = true;
                }
                if (foundzero)
                {
                    numbers.Enqueue(arr[i]);
                    arr[i] = numbers.Peek();
                    numbers.Dequeue();
                }

            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 0, 2, 3, 0, 4, 5, 0 };
            Solution solution = new Solution();
            solution.DuplicateZeros(array);
            Console.ReadKey();
        }
    }
}
