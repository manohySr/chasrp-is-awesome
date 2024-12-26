// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] args)
    {
        int[] input = [0, 0, 0, 0];

        Console.WriteLine("Before");
        print(input);

        Console.WriteLine("");
        moveZeroToEnd(input);
        Console.WriteLine("");

        Console.WriteLine("After");
        print(input);
    }


    public static void moveZeroToEnd(int[] input)
    {
        int indexOfZero = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != 0)
            {
                swapValueInIndex(input, indexOfZero, i);
                indexOfZero++;
            }
        }
    }


    public static void swapValueInIndex(int[] input, int indexA, int indexB)
    {
        int temp = input[indexA];
        input[indexA] = input[indexB];
        input[indexB] = temp;
    }

    public static void print(int[] input)
    {
        foreach (var item in input)
        {
            Console.Write(item);
            Console.Write(" - ");
        }
    }

    // Function to generate an int[] array with millions of values
    public static int[] GenerateInputArray(int size)
    {
        // Original small input
        int[] originalInput = { 0, 1, 0, 3, 12 };

        // Create a new array of the desired size
        int[] extendedInput = new int[size];

        // Copy original input into the new array
        Array.Copy(originalInput, extendedInput, originalInput.Length);

        // Fill the rest of the array with a mix of zeros and random non-zero values
        Random random = new Random();
        for (int i = originalInput.Length; i < size; i++)
        {
            // Randomly assign zero or a non-zero value (1-100)
            extendedInput[i] = random.Next(0, 2) == 0 ? 0 : random.Next(1, 101);
        }

        return extendedInput;
    }
}

