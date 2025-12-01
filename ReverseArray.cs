using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_C_
{
    internal class ReverseArray
    {
        public ReverseArray(int[] arr)
        {
            int len = arr.Length;
            int[] newArr = new int[len];

            //for (int i = len-2; i >=0; i--)
            //{
            //    newArr[i] = arr[i];
            //}

            int left = 0;
            int right = len-1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;

            }

            for (int i = 0; i <len; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
