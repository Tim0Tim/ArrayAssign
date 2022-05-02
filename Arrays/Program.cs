using System;

namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            //Random r1 = new Random();
            //int r1Int = r1.Next(10, 100);
            //Random r2 = new Random();
            //int r2Int = r2.Next(10, 100);
            //Random r3 = new Random();
            //int r3Int = r3.Next(10, 100);
            //Random r4 = new Random();
            //int r4Int = r4.Next(10, 100);
            //Random r5 = new Random();
            //int r5Int = r5.Next(10, 100);

            int r1Int = Convert.ToInt32(Console.ReadLine());
            int r2Int = Convert.ToInt32(Console.ReadLine());
            int r3Int = Convert.ToInt32(Console.ReadLine());
            int r4Int = Convert.ToInt32(Console.ReadLine());
            int r5Int = Convert.ToInt32(Console.ReadLine());

            int a1 = r1Int;
            int a2;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;

            if (r1Int == r2Int)
            {
                a2 = 0;
            }
            else
            {
                a2 = r2Int;
            }

            if (r3Int == r1Int || r3Int == r2Int)
            {
                a3 = 0;
            }
            else
            {
                if (a2 == 0)
                {
                    a2 = r3Int;
                }
                else
                {
                    a3 = r3Int;
                }
            }

            if (r4Int == r1Int || r4Int == r2Int || r4Int == r3Int)
            {
                a4 = 0;
            }
            else
            {
                if (a2 == 0)
                {
                    a2 = r4Int;
                }
                else if (a3 == 0)
                {
                    a3 = r4Int;
                }
                else
                {
                    a4 = r4Int;
                }
            }

            if (r5Int == r1Int || r5Int == r2Int || r5Int == r3Int || r5Int == r4Int)
            {
                a5 = 0;
            }
            else
            {
                if(a2 == 0)
                {
                    a2 = r5Int;
                }
                else if(a3 == 0)
                {
                    a3 = r5Int;
                }
                else if(a4 == 0)
                {
                    a4 = r5Int;
                }
                else
                {
                    a5 = r5Int;
                }
            }
   
            int[] array = { a1, a2, a3, a4, a5 };

            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{array[counter],8}");
            }
            //{counter,5}
            //Console.WriteLine($"{r1Int}, {r2Int}, {r3Int}, {r4Int}, {r5Int}");
        }
    }
}
//first create variables to place in array
//    then create comparision to prevent any repetitions
//    then create array
//    create write output
            //while (r1Int == r2Int || r1Int == r3Int || r1Int == r4Int || r1Int == r5Int
            //    || r2Int == r3Int || r2Int == r4Int || r2Int == r5Int
            //    || r3Int == r4Int || r3Int == r5Int
            //    || r4Int == r5Int)
            //{
            //    //finish the chages to the "just in case" situation
            //    if (r1Int == r2Int)
            //    {
            //        r2 = new Random();
            //    }
            //    if (r3Int == r1Int || r3Int == r2Int)
            //    {
            //        r3 = new Random();
            //    }
            //    if (r4 == r1 || r4 == r2 || r4 == r3)
            //    {
            //        r4 = new Random();
            //    }
            //    if (r5 == r1 || r5 == r2 || r5 == r3 || r5 == r4)
            //    {
            //        r5 = new Random();
            //    }
            //}