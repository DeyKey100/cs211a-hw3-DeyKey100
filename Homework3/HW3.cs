using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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




    }
}
