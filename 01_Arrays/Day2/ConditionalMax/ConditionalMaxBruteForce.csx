// Problem: Conditional Max  
// Description: Find the maximum among only the positive numbers.

using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {12,9999,5,6,-12,42,65,943,-124};

int? output = ConditionalMax(sampleNums);

if (output == null)
{
    Console.WriteLine("There's no positive number in the list");
}
else Console.WriteLine($"The maximum positive number in the list is {output}");

int? ConditionalMax(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    int? max = null;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0)
        {
            if (max == null || list[i] > max)
            {   
            max = list[i];
            }

        }
        
    }
    return max;
}