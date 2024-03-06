using System.Runtime.InteropServices;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a row width: ");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many number of rows?" );
            int rows = Int32.Parse(Console.ReadLine());

            //print rows
            Console.WriteLine();
            for (int i = 1 ; i <= rows; i++)
            {
                //inner for loop printing the width
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //print asterisk one per row until max number is reached
            Console.WriteLine("Max Asterisks in a row?");
            int maxAst = Int32.Parse(Console.ReadLine());

            for (int l = 1; l <= maxAst; l++)
            {
                //inner for loop printing the max asterisks per row
                for (int a = 1; a <= l; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}