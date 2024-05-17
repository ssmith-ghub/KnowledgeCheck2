using System; 

namespace KnowledgeCheckTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Guitar>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var guitar = new Guitar();

                Console.WriteLine("Does your guitar use bass cleff or treble Clef");
                guitar.Clef = Console.ReadLine();

                Console.WriteLine("How many strings does your guitar have?");
                guitar.Strings = Console.ReadLine();

                Console.WriteLine("What is the brand of your guitar?");
                guitar.Brand = Console.ReadLine();

                Console.WriteLine("What is the model of your guitar?");
                guitar.Model = Console.ReadLine();



                recordList.Add(guitar);
            }

            foreach (var guitar in recordList)
            {
                Console.WriteLine($"Clef: {guitar.Clef} Strings: {guitar.Strings} Brand: {guitar.Brand} Model: {guitar.Model}".ToString());
            }
            Console.ReadLine();

        }
    }
}
