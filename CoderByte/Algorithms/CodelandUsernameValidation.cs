using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoderByte.Algorithms
{
    public class CodelandUsernameValidation
    {
        public static string Run(string str)
        {
            if (str.Length < 4 || str.Length > 25)
                return "false";

            if (!char.IsLetter(str[0]))
                return "false";

            if (str[str.Length - 1] == '_')
                return "false";

            var x = new string((from l in str where !char.IsLetterOrDigit(l) && l != '_' select l).ToArray());

            if (x.Length > 0)
                return "false";

            return "true";
        }
    }
}
