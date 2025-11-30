namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
            for (int j = 0; j < 2; j++)
            {

                Console.WriteLine("What fruit would you like to find?: ");
                string usersFruit = Console.ReadLine().ToLower();
                for (int i = 0; i < fruits.Length; i++)
                {
                    if (usersFruit == fruits[i])
                    {
                        Console.WriteLine("True");
                        break;
                    }
                    if (i == fruits.Length - 1)
                    {
                        Console.WriteLine("False");
                    }
                }
            }
        }
    }
}
