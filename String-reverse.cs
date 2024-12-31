static class ReverseStringcls
{

    public static string ReverseString(string input)
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


// char[] charArray = new char[input.Length];
// for (int forwardIndex = 0, backwardIndex = input.Length - 1; backwardIndex >= 0; forwardIndex++, backwardIndex--)
// {
//    charArray[forwardIndex] = input[backwardIndex];
// }
// return new string(charArray);
