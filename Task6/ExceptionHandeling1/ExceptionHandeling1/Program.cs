using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionHandeling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char quit = ' ';

            try
            {
                Console.WriteLine("Enter the list:");
                do
                {
                    int n = int.Parse(Console.ReadLine());

                    if (!list.Contains(n))
                    {

                    list.Add(n);
                    }




                } while (quit != 'q');

            }
            catch (Exception ex)
            {

                throw new Exception($"there are dublicates in list",ex);

            }


        }

    }
}



