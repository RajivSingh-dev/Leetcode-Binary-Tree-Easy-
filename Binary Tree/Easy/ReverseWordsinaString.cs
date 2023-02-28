using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class ReverseWordsinaString
    {

        public string ReverseWords(string s)
        {
            

            string[] arr = s.Split(" ");
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                StringBuilder sbuilder = new StringBuilder(arr[i]);
                int low = 0, high = arr[i].Length - 1;
             while(low <= high) 
            {
                char ch = sbuilder.ToString()[low];
                sbuilder[low] = sbuilder[high];
                sbuilder[high] = ch;
                    low++;
                    high--;
            }
               
                res.Append(sbuilder.ToString());


                if (i == arr.Length - 1)
                    continue;
                res.Append(" ");

                
            }

            
           return res.ToString();  

        }





    }
}
