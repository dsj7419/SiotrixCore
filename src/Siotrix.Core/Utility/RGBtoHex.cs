using System;

namespace Siotrix
{
    public class RgBtoHex
    {
        public static string RgbToHexadecimal(Rgb rgb)
        {
            var rs = DecimalToHexadecimal(rgb.R);
            var gs = DecimalToHexadecimal(rgb.G);
            var bs = DecimalToHexadecimal(rgb.B);

            if (rs.Length == 1)
                rs = '0' + rs;

            if (gs.Length == 1)
                gs = '0' + gs;

            if (bs.Length == 1)
                bs = '0' + bs;

            return '#' + rs + gs + bs;
        }

        private static string DecimalToHexadecimal(int dec)
        {
            if (dec <= 0)
                return "00";

            var hex = dec;
            var hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                dec /= 16;
            }

            return hexStr;
        }

        public struct Rgb
        {
            public Rgb(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }

            public byte R { get; set; }

            public byte G { get; set; }

            public byte B { get; set; }

            public bool Equals(Rgb rgb)
            {
                return R == rgb.R && G == rgb.G && B == rgb.B;
            }
        }
    }
}