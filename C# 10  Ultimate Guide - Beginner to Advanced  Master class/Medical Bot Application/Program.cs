using MedicalBotApplicationMedicalBot;
using MedicalBotApplicationPatient;
using System.Diagnostics.Metrics;

namespace MedicalBotApplicationCore
{
    internal class Program
    {
        public static void Main()
        {
            System.Console.WriteLine($"Hi, I'm {MedicalBot.GetBotName}. I'm here to help you in your medication.");
            System.Console.WriteLine("Enter your details:");

            // Create New Patient
            Patient patient = new Patient();

            // Read patient details and validate them.
            System.Console.Write("Enter your name: ");
            while (!patient.SetName(System.Console.ReadLine(), out string errorMessage) )
            {
                Console.WriteLine(errorMessage);
                System.Console.Write("Enter your name: ");
            }

            // Read patient age
            System.Console.Write("Enter your age: ");
            while (!patient.SetAge(Convert.ToInt32(System.Console.ReadLine()),out string errorMessage) )
            {
                Console.WriteLine(errorMessage);
                System.Console.Write("Enter your age: ");
            }

            // Read patient gender
            System.Console.Write("Enter your gender: ");
            while (!patient.SetGender(System.Console.ReadLine(), out string errorMessage))
            {
                Console.WriteLine(errorMessage);
                System.Console.Write("Enter your gender: ");
            }

            // Read Medical History
            System.Console.Write("Enter Medical History: ");
            patient.SetMedicalHistory(System.Console.ReadLine());

            // Read symptoms
            System.Console.WriteLine($"Welcome, {patient.GetName}");
            System.Console.WriteLine("Which of the following symptoms you have");
            System.Console.WriteLine("S1. Headache \n S2. Skin rashes \n S3. Dizziness");
            System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
            while(!patient.SetSymptomCode(System.Console.ReadLine(), out string errorMessage))
            {
                System.Console.WriteLine(errorMessage);
                System.Console.WriteLine("Which of the following symptoms you have");
                System.Console.WriteLine("S1. Headache \n S2. Skin rashes \n S3. Dizziness");
                System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
            }

            // Create new MedicalBot
            MedicalBot medicalBot = new MedicalBot();
            medicalBot.PrescribeMedication(patient);

            // Output prescription
            System.Console.Write("Your prescription based on your age, symptoms and medical history: ");
            System.Console.WriteLine(patient.GetPrescription);

            // End program
            System.Console.WriteLine("Thank you for comming.");
        }
    }
}