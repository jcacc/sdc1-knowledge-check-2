


using SDC1_KC2;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

internal class Program
{ 
   private Animals 

    private static void Main(string[] args)
    {
       


        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());
       

        var recordList = new List<Animals>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Animal = new Animals();

            WriteLine("Enter the animal's name");
            string animalName = ReadLine();

            WriteLine("")




            recordList.Add(Animal);
        }

        // Print out the list of records using Console.WriteLine()

    }
}