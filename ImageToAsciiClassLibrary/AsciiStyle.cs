namespace ImageToAsciiClassLibrary
{
    public class AsciiStyle
    {
        /// <summary>
        ///     Represents the ASCII characters to be used when converting images to ASCII art
        /// </summary>
        /// <param name="charListFromDarkToLight">
        ///     A list of characters with index 0 being the character meant to represent the darkest parts of an image, and the last index to be the character that represents the lightest parts of an image
        /// </param>
        public AsciiStyle(char[] charListFromDarkToLight)
        {
            _charList = charListFromDarkToLight;
        }

        char[] _charList;

        /// <summary>
        ///     Returns a character that would represent <paramref name="LightnessValue"/>
        /// </summary>
        /// <param name="LightnessValue">
        ///     A value represengint how luminous an image or pixel is
        /// </param>
        public char GetCharFromLightnessValue(byte LightnessValue)
        {
            for (int i = 0; i < _charList.Length; i++)
            {
                if (LightnessValue <= (double)byte.MaxValue / _charList.Length * (i + 1))
                {
                    return _charList[i];
                }
            }
            return '?';
        }
    }
}
