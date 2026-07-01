// Problem: Frequency Count  
// Description: Count how many times each element appears using Dictionary.


int[] arr = { 2, 8, 2, 5, 8, 2, 6, 5 };
		
var acc = new Dictionary<int, int>();
		
for (int i = 0; i < arr.Length; i++)
{
	int currentNum = arr[i];
			
	if (!acc.ContainsKey(currentNum))
    {
        acc.Add(currentNum, 1);
    }
    else acc[currentNum]++;
}
		
foreach (var pair in acc)
{   
    Console.WriteLine($"Element Frequency Count: {pair.Key} {pair.Value}");
}