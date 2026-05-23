
//Problem: Count Evens  
//Description: Count how many elements are even.

using System;

int CountEvens (int [] arr) // Method
{
    int counter = 0; // Counter

    for(int i = 0; i < arr.Length; i++) // Iteration
    {
        if (arr[i] % 2 == 0) // Comparison + Indexing
        {
            counter++; // State update
        }
    }

    return counter;
}

int [] numbers = {2,4,5,6,8,10,11,12,13,14}; // Array 

Console.WriteLine($"Count evens: {CountEvens(numbers)}"); // String Interpolation + Method calling