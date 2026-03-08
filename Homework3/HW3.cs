using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework3
{
    public class HW3
    {
        static void Main(string[] args)
        {
        }

        // #1.
        public static string[] AddSpace(string[] mass)
        {
            if (mass == null)
                throw new ArgumentNullException("Null");;
            foreach (string s in mass)
            {
                if (s.Length % 2 == 0)
                    throw new ArgumentException("Длина строк должна быть нечётной");
            }

            int maxLen = mass.Max(s => s.Length);
            string[] result = new string[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                int space = (maxLen - mass[i].Length) / 2;
                result[i] = new string(' ', space) + mass[i] + new string(' ', space);
            }
            return result;
        }


        // #2.
        public static string RCN(string[] censor, string str)
        {
            if (str == null)
                throw new ArgumentException("string is null");
            if (censor == null || censor.Length == 0)
                return str;

            char[] deli = { ' ', ',', '.', '!', '?', ':', ';' };
            var result = new StringBuilder();
            var word = new StringBuilder();

            foreach (char ch in str)
            {
                if (deli.Contains(ch))
                {
                    if (word.Length > 0)
                    {
                        string w = word.ToString();
                        result.Append(censor.Contains(w) ? new string('*', w.Length) : w);
                        word.Clear();
                    }
                    result.Append(ch);
                }
                else
                {
                    word.Append(ch);
                }
            }

            if (word.Length > 0)
            {
                string w = word.ToString();
                result.Append(censor.Contains(w) ? new string('*', w.Length) : w);
            }

            return result.ToString();
        }


        // #3.




    }
}
