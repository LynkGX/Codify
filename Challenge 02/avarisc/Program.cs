using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    class Program
    {
        static void Main(string[] parameters)
        {
            string input = String.Join(" ", parameters);
            Console.WriteLine(RotationCipher.Rotate(13, input));
        }
    }

    static class RotationCipher
    {
        public static string Rotate(int rotation, string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipher = alphabet;

            //rotate the cipher
            rotation %= 26;
            if (rotation < 0) rotation = 26 - rotation; //convert negative rot to positive rot
            for(int r = 0; r < rotation; r++)
            {
                //take the first character and append it to the end, r times
                char first = cipher[0];
                cipher = cipher.Substring(1) + first;
            }

            //go letter by letter through the string
            char[] inputC = input.ToCharArray();
            for(int i = 0; i < inputC.Length; i++)
            {
                char c = inputC[i];
                if (Char.IsLetter(c))
                {
                    //find the position of the original letter in the alphabet
                    int position = alphabet.IndexOf(c.ToString().ToUpper()[0]);
                    //find the related letter in our ciphered alphabet
                    char ciphered = cipher[position];
                    //apply the uppercase, or lowercase letter as required
                    if (Char.IsUpper(c))
                    {
                        inputC[i] = ciphered;
                    } else
                    {
                        inputC[i] = ciphered.ToString().ToLower()[0];
                    }
                }
            }
            //return result
            return new string(inputC);
        }
    }
}
