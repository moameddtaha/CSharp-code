using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal class Question : IQuestion
    {
        public enum PermittedOptions
        {
            A, B, C, D
        }
        public string QuestionText { get; set; }
        public List<IOption> Options { get; set; }

        public char CorrectAnswerLetter
        {
            get => CorrectAnswerLetter;
            set
            {
                if (CorrectAnswerLetter != (char)PermittedOptions.A || CorrectAnswerLetter != (char)PermittedOptions.B || CorrectAnswerLetter != (char)PermittedOptions.C || CorrectAnswerLetter != (char)PermittedOptions.D)
                {
                    Console.WriteLine("Wrong Letter please enter A, B, C or D");
                }

                CorrectAnswerLetter = value;
            }
        }

        public char OptionSelectedByStudent { get; set; }
        public int MarksSecured { get; set; }
    }
}
