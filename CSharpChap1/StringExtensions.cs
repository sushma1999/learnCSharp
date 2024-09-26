public static class StringExtensions
{
    // Extension method to count the number of words in a string
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // Extension method to reverse a string
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}