// Problem: Find Last Negative  
// Description: Find the last negative number in the array.

using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {-12,24,-24,42,2,-2,12,-4,242,-24,555,23};

int? lastNegative = FindLastNegative(sampleNums);

Console.WriteLine(lastNegative);

int? FindLastNegative(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }


    for (int i = list.Count-1; i >= 0; i--)
    {
        if (list[i] < 0)
        {
            return list[i];
        }
    }
    return null;
}