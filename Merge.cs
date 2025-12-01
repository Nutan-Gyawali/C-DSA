using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_C_
{
    internal class Merge
    {
        int[] arr1 = { 2, 3, 4, 5 };
        int[] arr2 = { 2, 6, 6, 9 };

        public Merge()
        {
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int total = len1 + len2;

            int[] arr3 = new int[total];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < len1 && j < len2)
            {
                if (arr1[i] <= arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++; k++;
                }
            }
            while(i <len1)
            {
                arr3[k] = arr1[i];
                i++; k++;
            }
            while (j < len2)
            {
                arr3[k] = arr2[j]; k++; j++;
            }

            for(int l  = 0; l < total; l++)
            {
                Console.WriteLine(arr3[l]);
            }
        }

    
    }
}
