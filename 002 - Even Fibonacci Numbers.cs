using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long getFibSeq(long n, long sum, long first, long second)
    {
        while(second < n)
        {
                long toBeAdded = first;
                first = second;
                second = toBeAdded + second;
                
                if(second > n)
                {
                    break;
                }
                
                if(second % 2 == 0)
                {
                    sum += second;
                }
        }
        return sum;
    }
    
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            var seq = getFibSeq(n, (long)2,(long)1,(long)2);
            Console.WriteLine(seq);
        }
    }
}
