using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array__String
{
  static  class Class1
    {

      static  public void ShowArray(int[] a)
        {

            foreach (var b in a)
            {
                Console.WriteLine(b);
            }

            Array.Sort(a);
            Console.WriteLine("-----Sorted Array --------");
            foreach (var b in a)
            {
                Console.WriteLine(b);
            }
        }
       static public void ShowArrays(int [,] ss)
        {

            Console.WriteLine(ss.Rank);


            for (int i = 0; i < ss.GetLength(0); i++)
            {
                Console.WriteLine(ss[i, 0]);

                for (int j = 1; j < ss.GetLength(1); j++)
                {
                    Console.WriteLine(ss[i, j]);
                }
            }

        }

        static public void ShowArrays(int[][] ss)
        {

            //   Console.WriteLine(ss.Length);

            for (int i = 0; i < ss.Length; i++)
            {
                ss[i] = new int[i+1];
                Console.WriteLine("---------------------");
                for (int j = 0; j < ss[i].Length; j++)
                {
                    ss[i][j] = j;
                    Console.WriteLine(ss[i][j]);
                }

            }

            

        }


        static public void ModfStrings(string s)
        {
            for (int i = s.Length/2; i < s.Length/2+2; i++)
            {
                
               s= s.Insert(i,"d") ;
            }

            Console.WriteLine(s);

            
        }    


        static public void SomeSplit(string ss)
        {
            string[] s;
            s = ss.Split('g');

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
                
            }

            Console.WriteLine(new String('=', 30));

        }


        }




    
}
