// Problem: Search Element  
// Description: Check if a given number exists in the array.
int [] numbers = {1,2,3,4,5,6,7,8,9,10,11,12};
int target = 12;

bool isExist = SearchElement(numbers, target);

if (!isExist)
{
    Console.WriteLine($"The given element {target} doesnt exist in the array");
}

else Console.WriteLine($"The given element {target} exists in the array");

bool SearchElement(int [] arr, int target)
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("The array cant be null or 0");
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return true;
        }
    }
    return false;
}

