// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] args)
    {

        int[] input = [4, 1, 3, 2, 6, 5];
        // excpeted output = [1, 3, 5, 4, 2, 6]

        /*Console.WriteLine("Before");*/
        /*Print(input);*/
        /**/
        /*Console.WriteLine("");*/
        MoveOddToFront(input);
        /**/
        /*Console.WriteLine("");*/
        /**/
        /*Console.WriteLine("After");*/
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

        /*
         *                        if input[i] is even number *
                                  if input[i++] is odd number * 
                                  swap *
                                   
                                  if input[i] is even number *
                                  and there is no odd number until like input[i+3] *        =>      IMPLEMENTED USING Swap 
                                
                                  switch each one from the i+3 to the i *
         * */
        int evenIndex = 0;
        int oddIndex = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (IsOdd(input[i]))
            {
                oddIndex = i;
                Swap(input, evenIndex, oddIndex);
                evenIndex++;
            }
        }

    }

    public static void Swap(int[] input, int evenIndex, int oddIndex)
    {
        while (oddIndex > evenIndex)
        {
            int temp = input[oddIndex];
            input[oddIndex] = input[oddIndex - 1];
            input[oddIndex - 1] = temp;
            oddIndex--;
        }

    }

    public static bool IsOdd(int num)
    {
        return num % 2 != 0 ? true : false;
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

