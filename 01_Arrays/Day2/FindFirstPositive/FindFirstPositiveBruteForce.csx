// Problem: Find First Positive  
// Description: Find the first positive number in the List.

using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {-12,24,-24,42,2,-2,12,-4,242,-24,555,23};

int? firstPositive = FindFirstPositive(sampleNums);

Console.WriteLine(firstPositive);

int? FindFirstPositive(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0)
        {
            return list[i];
        }
    }
    return null;
}