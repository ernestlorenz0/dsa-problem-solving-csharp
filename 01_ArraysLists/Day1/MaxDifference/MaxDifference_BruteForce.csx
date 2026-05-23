//Problem: Max Difference  
//Description: Find the difference between the largest and smallest element.

(int max, int min, int diff) maxDifference(int[] arr) // [return type)] methodName [parameters] (return type is positional based) 
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or zero!");
    }
    
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return (max, min, max - min); // Tupple: to return multiple data (POSITIONAL BASED)
}

int [] numbers = {10,20,30,40,50,100};

var (max, min, diff) = maxDifference(numbers); // Deconstruction: to split tupple values into separate variables (POSITIONAL BASED)

Console.WriteLine($"Highest number: {max}");
Console.WriteLine($"Lowest number: {min}");
Console.WriteLine($"Difference: {diff}");