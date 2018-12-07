namespace RomanNumerals
{
    internal class RomanNumerals
    {
        public static string ConvertToRomanNumeral(int numericNumber)
        {
            var result = "";
            while (numericNumber > 0)
            {
                switch (numericNumber)
                {
                    case var _ when numericNumber >= 1000:
                        numericNumber -= 1000;
                        result += "M";
                        break;
                    case var _ when (numericNumber >= 500):
                        numericNumber -= 500;
                        result += "D";
                        break;
                    case var _ when (numericNumber >= 100):
                        numericNumber -= 100;
                        result += "C";
                        break;
                    case var _ when (numericNumber >= 50):
                        numericNumber -= 50;
                        result += "L";
                        break;
                    case var _ when (numericNumber >= 10):
                        numericNumber -= 10;
                        result += "X";
                        break;
                    case var _ when (numericNumber >= 5):
                        numericNumber -= 5;
                        result += "V";
                        break;
                    case var _ when (numericNumber >= 1):
                        numericNumber -= 1;
                        result += "I";
                        break;
                }
            }
            return result;
        }
    }
}