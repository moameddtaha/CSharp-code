using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedicalBotApplicationPatient;

namespace MedicalBotApplicationMedicalBot
{
    public class MedicalBot
    {
        internal const string BotName = "Bob";

        // 
        public static string GetBotName
        {
            get
            {
                return BotName;
            }
        }

        public void PrescribeMedication(Patient patient)
        {
            string? symptomCode = patient.GetSymptomCode();

            if (!string.IsNullOrEmpty(symptomCode) && symptomCode.Contains("Headache")) 
            {
                patient.SetPrescription = "ibuprofen " + GetDosage("ibuprofen");
                
            }
            if (!string.IsNullOrEmpty(symptomCode) && symptomCode.Contains("Skin rashes"))
            {
                patient.SetPrescription = "diphenhydramine " + GetDosage("diphenhydramine");
            }
            if(!string.IsNullOrEmpty(symptomCode) && symptomCode.Contains("Dizziness"))
            {
                if (patient.GetMedicalHistory == "diabetes")
                {
                    patient.SetPrescription = "metformin " + GetDosage("metformin");
                }
                else
                {
                    patient.SetPrescription = "dimenhydrinate " + GetDosage("dimenhydrinate");
                }
            }

            string GetDosage(string medicinName)
            {
                if (medicinName == "ibuprofen")
                {
                    if(patient.GetAge < 18)
                    {
                        return "400 mg";
                    }
                    else
                    {
                        return "800 mg";
                    }
                }
                if (medicinName == "diphenhydramine")
                {
                    if (patient.GetAge < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "300 mg";
                    }
                }
                if(medicinName == "dimenhydrinate")
                {
                    if (patient.GetAge < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "400 mg";
                    }
                }
                if(medicinName == "metformin")
                {
                    return "500 mg";
                }

                return "Unknown";
            }
        }
    }
}
