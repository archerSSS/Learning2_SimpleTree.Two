using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[14];
            for (int i = 0; i < 14; i++)
                numbers[i] = r.Next(13) +3;


            //  9; 4; 15; 11; 12; 10; 8; 6; 3; 3; 15; 4; 4; 7
            //  -15; -12; -8; -9; -12; -16; -13; -9; -12; -9; -6; -15; -5;
            int n1 = 9 | 4;         // 13
            int n2 = 15 ^ 11;       // 4
            int n3 = 12 & 10;       // 8
            int n4 = 8 << 2;        // 32
            int o1 = -15 | 6;       // -9
            int o2 = -12 ^ 3;       // -9
            int o3 = -8 & 3;        // 0
            int o4 = 15 >> 2;       // 3
            int p1 = -9 | -8;       // -1
            int p2 = -12 ^ -15;     // 5
            int p3 = -16 & -7;      // -16
            int p4 = -15 << 2;      // -60

            int s1 = -9 >> 2;       // -3

            // new SimpleTreeNode<int>(1, null)
        }
        //  1.01100
        //  1.00110
        //  1.01110
        //  0001
        //  0000
    }
}
