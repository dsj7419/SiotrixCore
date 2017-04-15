using System;

namespace Siotrix  
{
    public class RGBtoHex
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

        public static string RGBToHexadecimal(RGB rgb)
        {
            string rs = DecimalToHexadecimal(rgb.R);
            string gs = DecimalToHexadecimal(rgb.G);
            string bs = DecimalToHexadecimal(rgb.B);

            if(rs.Length == 1)
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

            int hex = dec;
            string hexStr = string.Empty;

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
    }
}
