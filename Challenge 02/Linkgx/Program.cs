using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = String.Join(" ", args);
            Console.WriteLine(Rot13.Transform(i));
        }
        static class Rot13
        {
            public static string Transform(string value)
            {
                char[] i_Rot13 = value.ToCharArray();
                for (int i = 0; i < i_Rot13.Length; i++)
                {
                    int charCode = (int)i_Rot13[i];

                    if (charCode >= 'a' && charCode <= 'z')
                    {
                        if (charCode > 'm')
                        {
                            charCode -= 13;
                        }
                        else
                        {
                            charCode += 13;
                        }
                    }
                    else if (charCode >= 'A' && charCode <= 'Z')
                    {
                        if (charCode > 'M')
                        {
                            charCode -= 13;
                        }
                        else
                        {
                            charCode += 13;
                        }
                    }
                    i_Rot13[i] = (char)charCode;
                }
                return new string(i_Rot13);
            }
        }
    }
}
