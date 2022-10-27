


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



            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());


            var animalList = new List<Animal>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var Animal = new Animal();

                WriteLine("Enter the animal's name");
                Animal.Name = ReadLine();

                





                animalList.Add(new Animal() { Name = Animal.Name });
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var animal in animalList)
            {
                WriteLine("Animal Name: "+ animal.Name);
            }
        }
    }
}
