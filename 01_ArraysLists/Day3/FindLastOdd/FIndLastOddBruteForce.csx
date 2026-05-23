using System;
using System.Collections.Generic; 

// Problem: Find Last Odd  
// Description: Find the last odd number in the array/list.

// Solution 1: Simple way hardcoded no edge cases doesnt follow SRP () 
int [] arr = {1,2,3,4,5,6,7,8,9,10};

for (int i = arr.Length - 1; i >= 0; i--)
{
    if (arr[i] % 2 != 0)
    {
        Console.WriteLine(arr[i]);
        break;
        
    }
}


// Solution 2: Complex solution follows the Single Responsibility Principle with edge cases
List<int> sampleNumbers = new List<int> { 3, 5032, 23454, 654, 234, 1112, 56, -34, 202, 234};

int? output =  FindLastOdd(sampleNumbers);

if (output == null)
{
    Console.WriteLine("There has no odd number in the list");
}
else Console.WriteLine(output);

int? FindLastOdd(List<int> num)
{
    if (num == null)
    {
        throw new ArgumentNullException("List cannot be null");
    }

    for (int i = num.Count - 1; i >= 0; i--)
    {
        if (num[i] % 2 != 0)
        {
            return num[i];
        }

    }

    return null;
} 



