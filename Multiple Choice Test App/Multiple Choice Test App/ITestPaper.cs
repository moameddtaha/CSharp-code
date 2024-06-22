using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal interface ITestPaper
    {
        string SubjectName { get; set; }
        string TestPaperName { get; set; }
        List<IQuestion> Questions { get; set; }
    }
}
