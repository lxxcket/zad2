// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Average in array of ints is: " + avg(array));

        int[] arrMax = { 1, 123, 435, 2, 14, 56, 343 };
        Console.WriteLine("Max value in array is: " + max(arrMax));
    }

    public static int avg(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        Console.WriteLine("edited in feature-new branch");
        return sum / arr.Length;
    }

    public static int max(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}