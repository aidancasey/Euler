using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Helpers
{
    public class Utils
    {
        public static string Reverse(string stringRepresentation)
        {
            var charArray = stringRepresentation.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
