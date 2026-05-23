// Problem: Check All Positive  
// Description: Return true if all numbers are positive, false otherwise.

using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {12,24,23,535,34,346,765,732,234,253,35,235,23,-12};

bool result = CheckAllPositive(sampleNums);

Console.WriteLine(result);

bool CheckAllPositive(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < 0)
        {
            return false;
        }
    }
    return true;
}