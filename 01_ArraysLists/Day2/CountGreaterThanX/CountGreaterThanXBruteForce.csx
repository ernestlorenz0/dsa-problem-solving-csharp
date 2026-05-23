// Problem: Count Greater Than X  
// Description: Count how many elements are greater than a given number X.



using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {12,9999,5,6,-12,42,65,943,-124};
int target = 100;

int output = CountGreaterThan(sampleNums, target);

if (output == 0)
{
    Console.WriteLine($"There's no number in the array that is greater than the given number {target}");
}
else Console.WriteLine($"The amount of elements that are greater than the given number are {output}");

int CountGreaterThan(List<int> list, int target)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    int counter = 0;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > target)
        {
            counter++;
        }
        
    }
    return counter;
}