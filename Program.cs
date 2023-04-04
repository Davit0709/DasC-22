using System;

class Program
{
    static void Main()
    {
        int[,,] array = new int[2, 2, 2];
        int count = 10;
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    array[x, y, z] = count;
                    count++;
                }
            }
        }

        int rowNum = 0;

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    Console.Write(array[x, y, z].ToString().PadLeft(2, '0'));
                    Console.Write("(" + x + "," + y + "," + z + ") ");


                    if (z == 1)
                    {
                        rowNum++;
                        Console.WriteLine("Row " + rowNum);
                    }
                }
            }
        }
    }
}
