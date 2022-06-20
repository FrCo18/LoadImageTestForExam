using System.Text.RegularExpressions;

namespace TestExam.Helpers
{
    internal class StringHelper
    {
        public static bool isNumber(string str)
        {
            return Regex.IsMatch(str, @"^\d+$");
        }

        public static bool isEmail(string str)
        {
            return Regex.IsMatch(str, @"^[\w\d]+@\w+\.\w+$");
        }
    }
}
