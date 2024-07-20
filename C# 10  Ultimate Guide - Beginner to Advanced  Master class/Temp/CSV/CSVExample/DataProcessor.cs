using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVExample
{
    public class DataProcessor
    {
        public string? ChunkName { set; get; }
        public List<string>? Chunk { set; get; }
        public Dictionary<string, int> GenderCounts = new Dictionary<string, int>();

        public void ProcessChunk()
        {
            // e.g: 1,Carissa,Preuvost,cpreuvost0@noaa.gov,Female

            foreach (string line in Chunk)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] values = line.Split(',');

                if (values.Length >= 5)
                {
                    string gender = values[4].Trim().ToLower();

                    if (GenderCounts.ContainsKey(gender))
                    {
                        GenderCounts[gender]++;
                    }
                    else
                    {
                        GenderCounts.Add(gender, 1);
                    }
                }
                // Simulate delay
                Random random = new Random();
                Thread.Sleep(100 * random.Next(2,5));
            }
        }
    }
}