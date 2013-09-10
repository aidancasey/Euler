using System;

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
