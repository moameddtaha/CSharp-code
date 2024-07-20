using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal interface IQuestion
    {
        string QuestionText { get; set; }
        List<IOption> Options { get; set; }
        char CorrectAnswerLetter { get; set; }
        char OptionSelectedByStudent { get; set; }
        int MarksSecured { get; set; }
    }
}
