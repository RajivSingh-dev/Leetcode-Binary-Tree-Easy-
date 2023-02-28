using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Arrayimplementation
    {

        static int root  = 0;
        static String[] str = new String[10];

       public void Root(string s)
        {
            str[0] = s;
        }

        public void set_Right(String key, int root)
        {

            int t = root*2 + 2;

            if (str[root] == null) 
                   {
                Console.Write("Can't set child at {0}, no parent found\n", t);

            }
            else {
                str[t] = key;
            }




        }
        
        public void set_Left(String key, int root)
        {

            int t = root * 2 + 1;

            if (str[root] == null)
            {
                Console.Write("Can't set child at {0}, no parent found\n", t);

            }
            else
            {
                str[t] = key;
            }
        }


        public void print_Tree()
        {
            for (int i = 0; i < 10; i++)
            {
                if (str[i] != null)
                    Console.Write(str[i]);
                else
                    Console.Write("-");
            }
        }


    }
}
