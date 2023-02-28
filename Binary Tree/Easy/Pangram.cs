using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Pangram
    {

        public bool CheckIfPangram(string alphabets,string sentence)
        {

            bool res = alphabets.Any(x => !sentence.Contains(x));

            return !res;
        }

    }
}
