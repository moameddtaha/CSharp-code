using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal class TestPaper : ITestPaper
    {
        public string SubjectName { get; set; }
        public string TestPaperName { get; set; }
        public List<IQuestion> Questions { get; set; }
    }
}
