// Problem: Check Any Negative  
// Description: Return true if there is at least one negative number.

using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {12,24,23,535,34,346,765,732,234,253,35,235,23,-12};

bool result = CheckAnyNegative(sampleNums);

Console.WriteLine(result);

bool CheckAnyNegative(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < 0)
        {
            return true;
        }
    }
    return false;
}