using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    // This method returns a Task<string>, representing the asynchronous operation that will eventually return the file content as a string.
    internal class FileReader
    {
        public async Task<string> ReadFile(string fileName)
        {
            // throw new NotSupportedException(); // Simulates an exception being thrown

            using (StreamReader reader = new StreamReader(fileName))
            {
                // ReadToEndAsync initiates an asynchronous read operation and returns a task that represents the operation. 
                // 'await' asynchronously waits for the task to complete and retrieves the result.
                string content = await reader.ReadToEndAsync();

                return content; // Returns the content read from the file as a string.

            } // Dispose is called automatically at the end of the using block

        }
    }
}
