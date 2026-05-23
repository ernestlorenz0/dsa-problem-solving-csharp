// Problem: First Index Search  
// Description: Find the index of the first occurrence of a given number.


using System;

int FirstIndexSearch (int [] arr, int target)
{

    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or zero.");
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return i;
        }
    }
    
    return -1;
}

int [] numbers = {21,2,3,2,200,24,200,300,412,412,-23,-25,-202,210,200,21,9,21};
int target = 100; //index 5
int foundIndex = FirstIndexSearch(numbers, target);

if (foundIndex == -1)
{
    Console.WriteLine($"Failed: The number {target} was not found in the array.");
}
else Console.WriteLine($"Sucess: Found the number {target} in the index {foundIndex}");

