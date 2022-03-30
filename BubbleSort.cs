using System;

public class BubbleSort
{
    public static void BubbleSort(int[] array)
    {
        int numOfItem = array.Length;
        for(int i = 0; i < numOfItem - 1; i++)
        {
            for(int j = 0; j < numOfItem - 1; j++) 
            {
                if (array[n] > array[j+1])
                {
                    int smallerValue = array[j+1];
                    array[j+1] = array[i];          // Swap greater value with smaller index to the greater index
                    array[i] = smallerValue;
                }
            }
        }
    }

	/* Prints the array */
	static void Print(int[] array)
	{
        foreach (int item in array)
        {
            Console.Write(item + ' ');
        }
        Console.WriteLine();
	}

	// Driver method
	public static void Main()
	{
		int[] array = {64, 34, 25, 12, 22, 11, 90};
		bubbleSort(array);
		Console.WriteLine("Sorted array");
		Print(array);
	}

}
