//Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.

//The Pin should be exactly 4 digits or 6 digits.

//If the supplied pin is invalid, it shows error message.


//Examples:

//Pin = "1234"-- > valid

//Pin = "1234ef"-- > invalid

//Pin = "123456"-- > valid

//Pin = "0"-- > invalid

//Pin = "a4"-- > invalid


namespace Card
{
    internal class DebitCard
    {
        private string? _pin;

        public string Pin
        {
            set
            {
                if(value != null || value != "")
                {
                    if (value?.Length == 4 || value?.Length == 6)
                    {
                        bool isValid = true;
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i] < 48 || value[i] > 57)
                            {
                                isValid = false;
                            }
                        }
                        if (isValid)
                        {
                            _pin = value;
                        }
                        else
                            System.Console.WriteLine("PIN contains one or more non-digit characters.");
                    }
                    else
                    {
                        System.Console.WriteLine("Pin must be 4 or 6 digits only");
                    }
                }
                else
                {
                    Console.WriteLine("The value can't be blank");
                }
            }
            get
            {
                return _pin;
            }
        }
    }
}

