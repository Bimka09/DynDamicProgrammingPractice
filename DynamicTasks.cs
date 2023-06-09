using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingPractice
{
    static class DynamicTasks
    {
        private static bool Even(int number) => (number & 1) == 0;
        private static bool Odd(int number) => (number & 1) == 1;

        public static int LCD(int a, int b)
        {
            if(a == b) return a;
            if(a == 0) return b;
            if(b == 0) return a;
            if (Even(a) && Even(b)) return LCD(a >> 1, b >> 1) << 1;
            if (Even(a) && Odd(b)) return LCD(a >> 1, b);
            if (Odd(a) && Even(b)) return LCD(a, b >> 1);

            if(a > b) return LCD((a - b) >> 1, b);
            else return LCD(a, (b - a) >> 1);
        }
        public static int Tree(int[,] tree)
        {
            var height = tree.GetUpperBound(0);
            for(int i = height - 1; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (tree[i + 1, j] > tree[i + 1, j + 1])
                        tree[i, j] += tree[i + 1, j];
                    else
                        tree[i, j] += tree[i + 1, j + 1];
                }
            }
            return tree[0, 0];

        }
        public static long CountAmountOfNumbers(int rank)
        {
            long f5 = 1;
            long f8 = 1;
            long f55 = 0;
            long f88 = 0;
            long n5, n8, n55, n88;

            for(long j = 2; j <= rank; j++)
            {
                n5 = f8 + f88;
                n8 = f5 + f55;
                n55 = f5;
                n88 = f8;
                f5 = n5;
                f8 = n8;
                f55 = n55;
                f88 = n88;
            }
            return f5 + f8 + f55 + f88;
        }
        public static int CountIlands(int[,] map)
        {
            int n = map.GetUpperBound(0); ;
            int countIlands = 0;
            for(int x = 0; x <= n; x++)
            {
                for(int y = 0; y <= n; y++)
                {
                    if (map[x,y] == 1)
                    {
                        countIlands++;
                        Walk(map, x, y, n);
                    }
                }
            }
            return countIlands;
        }
        private static void Walk(int[,] map, int x, int y, int n)
        {
            if (x < 0 || x > n) return;
            if (y < 0 || y > n) return;
            if (map[x, y] == 0) return;
            map[x, y] = 0;
            Walk(map, x - 1 ,y, n);
            Walk(map, x + 1, y, n);
            Walk(map, x, y - 1, n);
            Walk(map, x, y + 1, n);
        }
    }
}
