using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC_Assignment_2_2.Extensions
{
    public static class StringExtensions
    {
        public static string ToDigitsOnly(this string str)
        {
            return Regex.Replace(str, "[^0-9.]", string.Empty);
        }
    }
}