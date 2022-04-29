using System;

namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            Random r1 = new Random();
            int r1Int = r1.Next(10 ,100);
            Random r2 = new Random();
            int r2Int = r2.Next(10 ,100);
            Random r3 = new Random();
            int r3Int = r3.Next(10 ,100);
            Random r4 = new Random();
            int r4Int = r4.Next(10 ,100);
            Random r5 = new Random();
            int r5Int = r5.Next(10 ,100);

            while (r1Int == r2Int || r1Int == r3Int || r1Int == r4Int || r1Int == r5Int
                || r2Int == r3Int || r2Int == r4Int || r2Int == r5Int
                || r3Int == r4Int || r3Int == r5Int
                || r4Int == r5Int)
            {
                //finish the chages to the just in case situation
                if (r1Int == r2Int)
                {
                    r2 = new Random();
                }
                if (r3Int == r1Int || r3Int == r2Int)
                {
                    r3 = new Random();
                }
                if (r4 == r1 || r4 == r2 || r4 == r3)
                {
                    r4 = new Random();
                }
                if (r5 == r1 || r5 == r2 || r5 == r3 || r5 == r4)
                {
                    r5 = new Random();
                }
            }

            Console.WriteLine($"{r1Int}, {r2Int}, {r3Int}, {r4Int}, {r5Int}");
        }
    }
}
//first create variables to place in array
//    then create comparision to prevent any repetitions
//    then create array
//    create write output