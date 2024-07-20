using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            string fileName = "../../../Countries.txt";

            FileWriter fileWriter = new FileWriter();
            FileReader fileReader = new FileReader();

            // Write data to a file asynchronously
            // Asynchronously waits for the read operation to complete without blocking the calling thread, only the current async method.
            await fileWriter.WriteFile(fileName, "There are 195 recognised countries in the world, according to the United Nations. 193 of these are member states of the UN.");

            Console.WriteLine("File written.");

            try
            {
                // Read data from the file asynchronously
                // Waits asynchronously for the read operation to complete without blocking the calling thread, and assigns the resulting content to the string variable.
                string content = await fileReader.ReadFile(fileName);

                Console.WriteLine("File read.");

                Console.WriteLine($"\nFile content: {content}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}