namespace ExceptionHandeling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();
                CheckVowels(input);
                Console.WriteLine("The string contains vowels.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
           }
        }

        static void CheckVowels(string input)
        {
            

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in vowels)
            {
                if (input.Contains(c))
                {
                    return;
                }

            }
            throw new Exception("The string does not contain any vowels.");


        }
    }
}
