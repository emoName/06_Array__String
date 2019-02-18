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

            int[] a = new int[] { 5,3,5,7,10,2,2,2,2,2,2};
            int[,] b = new int[,] { {2,5 },{6,8},{5,0} };
            int[][] c = new int[4][];
            int[] d = (int[])a.Clone();
            Class1.ShowArray(a);
            Class1.ShowArrays(b);
            Class1.ShowArrays(c);

            Array.Reverse(d);
            Class1.ShowArray(d);





            Class1.ModfStrings("aaaaabbbbbbbb");
            Class1.SomeSplit("uifgduiggugo");


            Console.WriteLine("---------------------------------------------------");

          
            // Return int 
            Console.WriteLine("vyy".CompareTo("yvy"));
            Console.WriteLine("fufi".Contains("vv"));
            string s = "uuigbiginoih";
            // return Bool 
            Console.WriteLine("uyf".Equals("yiohoh"));
            Console.WriteLine("yuui"=="uiguigui");

            Console.WriteLine($"{s.PadRight(15, 's')}");
            Console.WriteLine(s.PadLeft(15,'s')+"\n Rind nou");


            Console.ReadLine();
        }
    }
}
