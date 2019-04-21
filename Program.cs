 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var longestSubSequense = -1;
            var longestSubIndex = -1;
            var longestSubSum = -1;
            var indexOfLongest = 0;
            var sequense=new int[length];
            var input = Console.ReadLine();
            var indexOfsequence = 1;
            while (input!="Clone them!")
            {
                var currentSequence = input
                    .Split(new char[] {'!'},StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                var SubSequense = 0;
                var SubIndex = 0;
                var SubSum = 0;
                var count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        count++;
                        SubSum++;
                        if (count>SubSequense)
                        {
                            SubSequense = count;
                            SubIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (SubSequense > longestSubSequense)
                {
                    longestSubSequense = SubSequense;
                    longestSubIndex = SubIndex;
                    longestSubSum = SubSum;
                    sequense = currentSequence;
                    indexOfLongest = indexOfsequence;
                }
                else if (SubSequense == longestSubSequense
                    && longestSubIndex>SubIndex)
                {
                    longestSubIndex = SubIndex;
                    longestSubSum = SubSum;
                    sequense = currentSequence;
                    indexOfLongest = indexOfsequence;
                }
                else if (SubSequense == longestSubSequense
                    && SubIndex == longestSubIndex
                    &&longestSubSum<SubSum)
                {
                    longestSubSum = SubSum;
                    sequense = currentSequence;
                    indexOfLongest = indexOfsequence;
                }
                indexOfsequence++;
                 input = Console.ReadLine();
            }
            Console.WriteLine("Best DNA sample {0} with sum: {1}."
                , indexOfLongest
                , longestSubSum);
            foreach (var item in sequense)
            {
                Console.Write(item+" ");
            }
        }
    }
}


