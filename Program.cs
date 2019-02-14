using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array__String
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 5,3,5,7,10};

            Class1.ShowArray(a);

            int[,] b = new int[,] { {2,5 },{6,8},{5,0} };

            Class1.ShowArrays(b);

            int[][] c = new int[4][];
              Class1.ShowArrays(c);


            Class1.ModfStrings("aaaaabbbbbbbb");

            Class1.SomeSplit("uifgduiggugo");





            Console.ReadLine();
        }
    }
}
