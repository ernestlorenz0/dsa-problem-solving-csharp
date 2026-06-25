// PROBLEM: Unique Elements  
// DESCRIPTION: Return all unique elements from the array.


int[] arr = { 4, 5, 4, 6, 5, 7, 8 };

HashSet<int> uniqueElements = new HashSet<int>();

for (int i = 0; i < arr.Length; i++) 
{
    uniqueElements.Add(arr[i]); 
}

Console.WriteLine("Unique Elements:"); 
foreach (int value in uniqueElements){
    Console.Write(value + " ");
}



