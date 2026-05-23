// Problem: Find Minimum
// Description: Given an array of integers, find the minimum value.


using System; 

int FindMinimum (int [] arr)
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Array cannnot be empty or null!");
    }

    int minimum = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minimum)
        {
            minimum = arr[i];
        }
    }
    return minimum;
}


int [] numbers = {200,300,400,500,0,-12,421,-1,-12222,9999,-999999};

Console.WriteLine($"Find minimum: {FindMinimum(numbers)}");