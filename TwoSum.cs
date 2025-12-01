using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_C_
{
    internal class TwoSum
    {
        public TwoSum() {
            int[] arr1 = { 2, 4, 5, 7, 8 };
            int target = 10;

            Dictionary<int,int> array= new Dictionary<int, int>();
            for(int i = 0; i < arr1.Length; i++)
            {
                int complement = target - arr1[i];
                if (array.ContainsKey(complement))
                {
                    Console.WriteLine("pair found + { complement} +  {arr[i]}"); 
                    Console.WriteLine($"Pair found: {complement} + {arr1[i]} = {target}");
                }
                array[arr1[i]] = i;
            }
        }

    }
}
