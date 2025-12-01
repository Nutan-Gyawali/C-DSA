using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_in_C_
{
    public class Count
    {
        public Count (string message)
        {
            Dictionary<char, int> dict = new Dictionary<char,int>();
            foreach (char c in message)
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
             Console.WriteLine("\nCharacter Frequency:");
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
