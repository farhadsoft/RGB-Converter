﻿using System;
using System.Drawing;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            if (red < 0 || red > 255)
            {
                red = (red < 0) ? 0 : 255;
            }

            if (green < 0 || green > 255)
            {
                green = (green < 0) ? 0 : 255;
            }

            if (blue < 0 || blue > 255)
            {
                blue = (blue < 0) ? 0 : 255;
            }

            return ColorTranslator.ToHtml(Color.FromArgb(red: red, green: green, blue: blue))[1..];
        }
    }
}
