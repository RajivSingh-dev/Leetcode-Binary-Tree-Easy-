using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Tree
    {


        static void Main(string[] args)
        {


                Arrayimplementation arrayimplementation= new Arrayimplementation();
                arrayimplementation.Root("a");
            arrayimplementation.set_Left("b",0);
            arrayimplementation.set_Right("c",0);
            arrayimplementation.set_Left("d",1);
            arrayimplementation.set_Right("e",1);
            arrayimplementation.set_Right("f",2);
            arrayimplementation.print_Tree();



        }



    }
}
