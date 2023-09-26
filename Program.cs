namespace LeetCode_125;

class Program
{
    static void Main()
    {
        IsPalindrome("a.");
    }

    static bool IsPalindrome(string s)
    {
        // Specify splitPoints to use as split points
        char[] splitPoints =
        {
            ' ', '(', ')', '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '-', '+', '=', '|', '\\', '{', '}', '[',
            ']', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/', '_'
        };
        string[] words = s.Split(splitPoints);

        // Merge array contents
        string filtered = String.Join("", words);

        // Convert filtered string to char array
        char[] filteredCharacters = filtered.ToCharArray();

        // Reverse the array
        Array.Reverse(filteredCharacters);

        // Store result as string
        string reversed = new(filteredCharacters);

        // Check if filtered and reversed string are equal
        if (filtered.ToLower() == reversed.ToLower())
        {
            Console.WriteLine("The string is a palindrome...");
            return true;
        }

        Console.WriteLine("{0}, {1}", filtered.ToLower(), reversed.ToLower());
        Console.WriteLine("The string is not a palindrome...");
        return false;
    }
}