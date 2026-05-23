// Problem: Find Maximum  
// Description: Given an array of integers, find the maximum value.


using System; 

int FindMaximum (int [] arr)
{
    
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Array cannot be empty or null!!!!!");  
    }

    int maximum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maximum)
        {
            maximum = arr[i];
        }
    }
    return maximum;
}

int [] numbers = {100,200,43,23,520,235,135,-234,150,9999};

Console.WriteLine($"Find maximum: {FindMaximum(numbers)}");