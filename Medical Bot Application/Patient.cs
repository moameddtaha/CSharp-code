using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalBotApplicationPatient
{
    public class Patient
    {
        // Fields
        private string? name;
        private int? age;
        private string? gender;
        private string? medicalHistory;
        private string? symptomCode;
        private string? prescription;

        // Name setter and getter
        public bool SetName(string name, out string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2)
            {
                this.name = name;
                errorMessage = string.Empty;
                return true;
            }
            else
            {
                errorMessage = "Name cannot be empty or whitespace.";
                return false;
            }
        }
        public string? GetName
        {
            get { return this.name; }
        }

        // Age setter and getter
        public bool SetAge(int? age, out string errorMessage)
        {
            if (age.HasValue)
            {
                if (age >= 0)
                {
                    if(age < 100)
                    {
                        this.age = age;
                        errorMessage = string.Empty;
                        return true;
                    }
                    else
                    {
                        errorMessage = "Age cannot be greater than 100.";
                        return false;
                    }
                }
                else
                {
                    errorMessage = "Age cannot be negative.";
                    return false;
                }
            }
            else
            {
                errorMessage = "Age cannot be empty.";
                return false;
            }
        }

        public int? GetAge
        {
            get { return this.age; }
        }

        // Gender setter and getter
        public bool SetGender(string? gender, out string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(gender))
            {
                gender = gender.ToLower();
                if (gender == "male" || gender == "female")
                {
                    this.gender = gender;
                    errorMessage = string.Empty;
                    return true;
                }
                else
                {
                    errorMessage = "invalid genderm, gender can only be Male or Female";
                    return false;
                }
            }
            else
            {
                errorMessage = "Gemder cannot be empty or whitespace.";
                return false;
            }
        }

        public string? GetGender
        {
            get { return this.gender; }
        }

        // Medical History setter and getter
        public void SetMedicalHistory(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                this.medicalHistory = value.ToLower();
            }
        }
        public string GetMedicalHistory
        {
            get { return this.medicalHistory ?? string.Empty; }
        }

        // Symptom Code setter and getter

        public bool SetSymptomCode(string symtomCode, out string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(symtomCode))
            {
                this.symptomCode = symtomCode.ToUpper();
                errorMessage = string.Empty;
                return true;
            }
            else
            {
                errorMessage = "Symptom Code can't be null or whitespace.";
                return false;
            }
        }

        public string? GetSymptomCode()
        {
            if(!string.IsNullOrWhiteSpace(symptomCode))
            {
                string description;
                if(symptomCode == "S1")
                {
                    description = "Headache";
                    return description;
                }
                else if(symptomCode == "S2")
                {
                    description = "Skin rashes";
                    return description;
                }
                else if (symptomCode == "S3")
                {
                    description = "Dizziness";
                    return description;
                }
                else
                {
                    description = "Unknown";
                    return description;
                }
            }
            else
            {
                return "Symptom Code is null or contain only whitespace.";
            }
        }

        // Prescription setter and getter

        public string? SetPrescription
        {
            set { this.prescription = value; }
        }

        public string? GetPrescription
        {
            get { return this.prescription; }
        }

    }
}
