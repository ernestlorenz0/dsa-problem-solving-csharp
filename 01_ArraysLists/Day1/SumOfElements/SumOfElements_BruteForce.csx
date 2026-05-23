// Sum of Elements  
// Compute the sum of all elements in the array.
// Changed the structure of the code to Execution Layer first before Core Logic Layer


int [] arr = {20,20,20,20,-22340};

int sum = SumOfElements(arr);

Console.WriteLine($"The sum of all elements is {sum}");

int SumOfElements (int [] arr)
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("ARRAY CANT BE NULL OR ZERO!");
    }

    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];    
    }
    return sum;
}

