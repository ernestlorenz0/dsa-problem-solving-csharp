// Problem: Frequency Count  
// Description: Count how many times a given number appears.

// Implemented SOC 

using System;

int FrequencyCount (int [] arr, int givenNumber)
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or zero!");
    }

    int counter = 0; 

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == givenNumber)
        {
            counter++;
        }
    }
    return counter;
}


int [] numbers = {1,2,3,4,5,6,12,421,412,5,2,2,2,2};
int target = 2;

int totalCount = FrequencyCount(numbers, target); // variable initialization via method return value || method call + saving output of a function (bridge between Core Logic Layer and Execution Layer)


Console.WriteLine($"The target number {target} shown {totalCount}x");