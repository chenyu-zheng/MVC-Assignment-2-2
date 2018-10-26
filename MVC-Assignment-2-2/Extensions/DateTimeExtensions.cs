using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment_2_2.Extensions
{
    public static class DateTimeExtensions
    {
        public static int ToAge(this DateTime birthday)
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age)) age--;
            return age;
        }
    }
}