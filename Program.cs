// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] args)
    {
        string descriptionOfChamp = "The real CHAMP is: ";
        Console.WriteLine(descriptionOfChamp + MaximumInArray([3, 5, 7, 2, 8]));
    }

    public static int MaximumInArray(int[] input)
    {
        if (input.Length < 0)
        {
            throw new ArgumentException("the input array should have more than 1 element");
        }


        // so let's find the real one: THE REAL MAX CHAMP
        int maxInTitle = input[0]; //someone who pretends to be the best
        int iteration = 1;

        while (iteration < input.Length)
        {
            int currentChallenger = input[iteration];
            if (maxInTitle < currentChallenger)
            {
                maxInTitle = currentChallenger;
            }
            iteration++;
        }

        return maxInTitle;
    }
}

