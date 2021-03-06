﻿using System.Text.RegularExpressions;

namespace Packt.CS6
{
    public static class MyExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            // use simple regular expression to check 
            // that the input string is a valid email 
            return Regex.IsMatch(input, 
                @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }

        // this extension method matches the signature of an existing instance method
        public static string Insert(this string input, int startIndex, string value)
        {
            return "This extension method will never get called.";
        }
    }
}
