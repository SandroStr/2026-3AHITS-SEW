class Programm
{

    static void Main()
    {
        int[] arr = { 4, 7, 3, 6, 8, 2 };
        int pos = FindMax(arr);
        Console.WriteLine($"Maximum {arr[pos]} auf Index {pos}");
    }

    static int FindMax(int[] arr)
    {
        int maxPos = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > arr[maxPos])
                maxPos = i;
            
        }
        return maxPos;
    }
}