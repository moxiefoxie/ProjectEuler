using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    private static long sumOfMultiplesOfThreeAndFive(long max) 
    {
        long t1 = getCountMultiples(max, 3);
        long t2 = getCountMultiples(max, 5);
        long t3 = getCountMultiples(max, 15);
        return t1 + t2 - t3;
    }

    private static long getCountMultiples(long max, long n) 
    {
        long a = (max - 1) / n;
        return n * a * (a + 1) / 2;
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long sum = sumOfMultiplesOfThreeAndFive(n);
            Console.WriteLine(sum);
        }
    }
}
