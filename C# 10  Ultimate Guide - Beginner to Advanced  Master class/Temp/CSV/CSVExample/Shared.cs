using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVExample
{
    public class Shared
    {
        public static Mutex mutex { set; get; }
        public static string? FilePath { get; set; }
        public static int? ChunckSize { get; set; }
        public static int MinConcurrency { set; get; }
        public static int MaxConcurrency { set; get; }
        public static CountdownEvent Count { set; get; }

        static Shared()
        {
            mutex = new Mutex();
            FilePath = "../../../MOCK_DATA.csv";
            ChunckSize = 100;
            MaxConcurrency = 3;
            MinConcurrency = 3;
        }
    }
}