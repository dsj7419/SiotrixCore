using System;

namespace Siotrix
{
    public class HextoRGB
    {
        public struct RGB
        {
            private byte _r;
            private byte _g;
            private byte _b;

            public RGB(byte r, byte g, byte b)
            {
                _r = r;
                _g = g;
                _b = b;
            }

            public byte R
            {
                get { return _r; }
                set { _r = value; }
            }

            public byte G
            {
                get { return _g; }
                set { _g = value; }
            }

            public byte B
            {
                get { return _b; }
                set { _b = value; }
            }

            public bool Equals(RGB rgb)
            {
                return (R == rgb.R) && (G == rgb.G) && (B == rgb.B);
            }
        }

        public static RGB HexadecimalToRGB(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Remove(0, 1);

            byte r = (byte)HexadecimalToDecimal(hex.Substring(0, 2));
            byte g = (byte)HexadecimalToDecimal(hex.Substring(2, 2));
            byte b = (byte)HexadecimalToDecimal(hex.Substring(4, 2));

            return new RGB(r, g, b);
        }

        private static int HexadecimalToDecimal(string hex)
        {
            hex = hex.ToUpper();

            int hexLength = hex.Length;
            double dec = 0;

            for (int i = 0; i < hexLength; ++i)
            {
                byte b = (byte)hex[i];

                if (b >= 48 && b <= 57)
                    b -= 48;
                else if (b >= 65 && b <= 70)
                    b -= 55;

                dec += b * Math.Pow(16, ((hexLength - i) - 1));
            }

            return (int)dec;
        }
    }
}
