using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal class Option : IOption
    {
        public char OptionLetter { get; set; }
        public string OptionText { get; set; }
    }
}
