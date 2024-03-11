// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Average in array of ints is: " + avg(array));
        
        
    }

    public static int avg(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum / arr.Length;
    }
}