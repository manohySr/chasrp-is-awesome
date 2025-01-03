// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] args)
    {

        int[] input = [4, 1, 3, 2, 6, 5];
        // excpeted output = [1, 3, 5, 4, 2, 6]

        Console.WriteLine("Before");
        Print(input);

        Console.WriteLine("");
        MoveOddToFront(input);

        Console.WriteLine("");

        Console.WriteLine("After");
        Print(input);
    }


    public static void MoveOddToFront(int[] input)
    {
        // moving odd number to front also means:
        //    moving odd to front if the next current number is even



        if (input.Length == 0 || input.Length == 1)
        {
            return;
        }

        int i = 1;
        int indexRef = 0;
        while (input.Length > i)
        {
            if (!IsOdd(input[indexRef]))
            {
                if (IsOdd(input[i]))
                {
                    SwapValueInIndex(input, indexRef, i);
                    indexRef++;
                }
            }
            else
            {
                indexRef++;
            }
            Console.Write("Test: ");
            Print(input);
            Console.WriteLine("");


            i++;
        }

    }

    public static bool IsOdd(int num)
    {
        return num % 2 != 0 ? true : false;
    }

    public static void SwapValueInIndex(int[] input, int indexA, int indexB)
    {
        int temp = input[indexA];
        input[indexA] = input[indexB];
        input[indexB] = temp;
    }

    public static void Print(int[] input)
    {
        foreach (var item in input)
        {
            Console.Write(item);
            Console.Write(" - ");
        }
    }

}

