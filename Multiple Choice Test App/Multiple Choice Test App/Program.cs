using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Multiple_Choice_Test_App.Question;

namespace Multiple_Choice_Test_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1
            Console.WriteLine("Enter details for the test paper 1:");
            ITestPaper testPaper1 = CreateTestPaperFromInput();
            Console.WriteLine("Enter details for the test paper 2:");
            ITestPaper testPaper2 = CreateTestPaperFromInput();

            // Step 2
            Console.WriteLine("Enter student details");
            IStudent student = CreateStudentFromInput();

            Console.WriteLine("Student: " + student.StudentName);
            Console.WriteLine();

            // Attempt test paper 1
            Console.WriteLine("Test paper 1 - " + testPaper1.SubjectName + " - " + testPaper1.TestPaperName);
            TakeTestPaper(testPaper1);
            Console.WriteLine();

            // Attempt test paper 2
            Console.WriteLine("Test paper 2 - " + testPaper1.SubjectName + " - " + testPaper1.TestPaperName);
            TakeTestPaper(testPaper2);
            Console.WriteLine();

            //Step 3
            Console.WriteLine("Marks secured for " + testPaper1.TestPaperName + ": " + calculateMarksSecured(testPaper1));
            Console.WriteLine("Marks secured for " + testPaper1.TestPaperName + ": " + calculateMarksSecured(testPaper1));
        }

        static ITestPaper CreateTestPaperFromInput()
        {
            ITestPaper testPaper = new TestPaper();

            Console.Write("Enter subject name: ");
            testPaper.SubjectName = Console.ReadLine();

            Console.Write("Enter test paper name: ");
            testPaper.TestPaperName = Console.ReadLine();

            testPaper.Questions = new List<IQuestion>();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Enter details of question " + i + ": ");
                IQuestion question = CreateQuestionFromInput();
                testPaper.Questions.Add(question);
            }

            return testPaper;
        }

        static IQuestion CreateQuestionFromInput()
        {
            IQuestion question = new Question();

            Console.Write("Enter question text: ");
            question.QuestionText = Console.ReadLine();

            question.Options = new List<IOption>();
            for (char optionLetter = 'A'; optionLetter <= 'D'; optionLetter++)
            {
                Console.WriteLine("Enter option " + optionLetter + ": ");
                string optionText = Console.ReadLine();

                IOption option = new Option()
                {
                    OptionLetter = optionLetter,
                    OptionText = optionText
                };
                question.Options.Add(option);
            }

            Console.Write("Enter the correct answer letter: ");
            
            char correctAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);
            
            while (!CheckForCorrectAnswerValue(correctAnswerLetter))
            {
                Console.Write("Enter the correct answer letter: ");
                correctAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            question.CorrectAnswerLetter = correctAnswerLetter;
            return question;
        }

        static bool CheckForCorrectAnswerValue(char correctAnswerLetter)
        {
            if (correctAnswerLetter != (char)PermittedOptions.A || correctAnswerLetter != (char)PermittedOptions.B || correctAnswerLetter != (char)PermittedOptions.C || correctAnswerLetter != (char)PermittedOptions.D)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static IStudent CreateStudentFromInput()
        {
            IStudent student = new Student();

            Console.WriteLine("Enter roll number: ");
            student.RollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student name");
            student.StudentName = Console.ReadLine();

            student.TestPapers = new List<ITestPaper>();

            return student;
        }

        static void TakeTestPaper(ITestPaper testPaper)
        {
            foreach (var question in testPaper.Questions)
            {
                Console.WriteLine(question.QuestionText);
                foreach (var option in question.Options)
                {
                    Console.WriteLine(option.OptionLetter + ": " + option.OptionText);
                }

                Console.WriteLine("Enter your choice: ");
                question.OptionSelectedByStudent = Console.ReadLine().ToUpper()[0];
            }
        }

        static int calculateMarksSecured(ITestPaper testPaper)
        {
            int marksSecured = 0;
            foreach (var question in testPaper.Questions)
            {
                if(question.CorrectAnswerLetter.ToString().Equals(question.OptionSelectedByStudent.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    marksSecured++;
                }
            }

            return marksSecured;
        }
    }
}
