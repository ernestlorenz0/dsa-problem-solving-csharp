//Problem: Count Positives
//Description: Count how many elements are greater than or equal to zero.

using System; 

int CountPositives (int [] arr)
{
    int counter = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            counter++;
        }
    }
    return counter;
}

int [] numbers = {-12,1,-2,0,11,22,33,-4,5002,532,-25,100,200};
Console.WriteLine($"Count positives: {CountPositives(numbers)}");