using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretcher
{
    public static class IntExtensions
    {
        /// <summary>
        /// Rounds the integer up to the nearest 10.
        /// </summary>
        public static int RoundUpToTen(this int num)
        {
            return (int)(Math.Ceiling(num / 10.0d) * 10);
        }

        /// <summary>
        /// Converts the integer to its ordinal string representation.
        /// </summary>
        public static string ToOrdinal(this int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }

        }
    }
}