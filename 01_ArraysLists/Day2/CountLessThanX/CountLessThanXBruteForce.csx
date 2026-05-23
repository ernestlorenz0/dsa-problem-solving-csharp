// Problem: Count Less Than X  
// Description: Count how many elements are less than a given number X.



using System; 
using System.Collections.Generic;

List<int> sampleNums = new List<int> {101,-12,102,103,104,235,534,645,235,140,23,124,12};
int target = 100;

int output = CountLessThan(sampleNums, target);

if (output == 0)
{
    Console.WriteLine($"There's no number in the array that is less than the given number {target}");
}
else Console.WriteLine($"The amount of elements that are less than the given number are {output}");

int CountLessThan(List<int> list, int target)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("List cannot be empty or 0");
    }

    int counter = 0;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < target)
        {
            counter++;
        }
        
    }
    return counter;
}