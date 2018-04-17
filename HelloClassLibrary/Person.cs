using System;
using System.Text;

namespace HelloClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Greet()
        {
            var sb = new StringBuilder();
            sb.Append(
                DateTime.Now.Hour.Between(0,11) ? "Good morning" :
                DateTime.Now.Hour.Between(12,18) ? "Good afternoon" : 
                DateTime.Now.Hour.Between(19, 23) ? "Good night" : ""
                );
            sb.Append(", ");
            sb.Append(this.FirstName);
            return sb.ToString();
        }
    }

    internal static class IntExtension
    {
        public static bool Between(this int value, int min, int max, bool exclusive = false)
        {
            if (exclusive)
                return value > min && value < max;
            else
                return value >= min && value <= max;
        }
    }
}
