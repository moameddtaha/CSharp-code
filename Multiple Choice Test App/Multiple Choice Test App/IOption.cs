using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal interface IOption
    {
        char OptionLetter { get; set; }
        string OptionText { get;set; }
    }
}
