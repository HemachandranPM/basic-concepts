class Program
{
    static void Main(string[] args)
    {
        string original = "Hello, World!";
        string reversed = ReverseString(original);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string input)
    {
        char[] charArray = new char[input.Length];
        int forwardIndex = 0;
        int backwardIndex = input.Length - 1;

        while (backwardIndex >= 0)
        {
            charArray[forwardIndex] = input[backwardIndex];
            forwardIndex++;
            backwardIndex--;
        }

        return new string(charArray);
    }
}