using System;

namespace Siotrix
{
    public class HextoRgb
    {
        public static Rgb HexadecimalToRgb(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Remove(0, 1);

            var r = (byte) HexadecimalToDecimal(hex.Substring(0, 2));
            var g = (byte) HexadecimalToDecimal(hex.Substring(2, 2));
            var b = (byte) HexadecimalToDecimal(hex.Substring(4, 2));

            return new Rgb(r, g, b);
        }

        private static int HexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();

            var hexLength = hex.Length;
            double dec = 0;

            for (var i = 0; i < hexLength; ++i)
            {
                var b = (byte) hex[i];

                if (b >= 48 && b <= 57)
                    b -= 48;
                else if (b >= 65 && b <= 70)
                    b -= 55;

                dec += b * Math.Pow(16, hexLength - i - 1);
            }

            return (int) dec;
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