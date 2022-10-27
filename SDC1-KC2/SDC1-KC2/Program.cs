


using SDC1_KC2;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


namespace SDC1_KC2
{


    internal class Program
    {


        private static void Main(string[] args)
        {



            Console.WriteLine("How many shirts do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());


            var shirtList = new List<Shirt>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new Shirt();

                WriteLine("Enter the shirt brand: ");
                entry.Brand = ReadLine();

                WriteLine("Enter a short description of the design: ");
                entry.DesignDescription = ReadLine();

                WriteLine("Enter the color of shirt: ");
                entry.Color = ReadLine();

                WriteLine("What size is the shirt?: (S, M, L, XL)");
                entry.Size = ReadLine().ToUpper();

                            





               shirtList.Add(new Shirt() { Brand = entry.Brand, DesignDescription = entry.DesignDescription, Color = entry.Color, Size = entry.Size });


            }
            Clear();
            WriteLine("These are the shirts you entered...");
            // Print out the list of records using Console.WriteLine()
            foreach (var entry in shirtList)
            {
                
                
                WriteLine("Shirt Brand: " + entry.Brand);
                WriteLine("Description: " + entry.DesignDescription);
                WriteLine("Color: " + entry.Color);
                WriteLine("Size: " + entry.Size);
                WriteLine("");



            }
        }
    }
}
