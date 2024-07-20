using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileWriter
    {
        public async Task WriteFile(string fileName, string data)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                await writer.WriteAsync(data); // Starts the asynchronous write operation and returns a Task. The await keyword asynchronously waits for the Task to complete.

            } // Dispose is called automatically at the end of the using block
        }
    }
}
