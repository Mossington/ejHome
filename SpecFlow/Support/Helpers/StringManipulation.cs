using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejHome.SpecFlow.Support.Helpers
{
    public static class StringManipulation
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength){
                return value.Substring(0, maxLength);
            }
            return value;
        }
    }
}
