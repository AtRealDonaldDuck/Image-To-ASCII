using System;
using System.Drawing;
using System.Text;

namespace ImageToAsciiClassLibrary
{
    /// <summary>
    ///     Create ASCII art from images
    /// </summary>
    public class ImageToAscii
    {
        /// <summary>
        ///     Returns an ASCII art representation of the passed bitmap
        /// </summary>
        public string FromBitmap(Bitmap bmp, int numberOfCharacters, AsciiStyle style)
        {
            Bitmap[,] segments = SegmentImageAsMatrix(bmp, numberOfCharacters);

            StringBuilder outputAscii = new StringBuilder();

            for (int col = 0; col < segments.GetLength(0); col++)
            {
                for (int row = 0; row < segments.GetLength(1); row++)
                {
                    byte averageLightnessOfSegment = GetAverageLightnessValues(segments[col, row]);
                    char segmentAsChar = style.GetCharFromLightnessValue(averageLightnessOfSegment);
                    outputAscii.Append(segmentAsChar);
                }
                outputAscii.Append("\n");
            }

            return outputAscii.ToString();
        }
        public string FromBitmap(Bitmap bitmap, int charactersPerLine)
        {
            return FromBitmap(bitmap, charactersPerLine, new AsciiStyle(new char[] { '#', '$', '&', '!', ':', ',', '.', ' ' }));
        }
        public string FromBitmap(Bitmap bitmap)
        {
            return FromBitmap(bitmap, 80);
        }

        //returns the sum of every pixels lightness value / how many pixels in the bitmap
        private byte GetAverageLightnessValues(Bitmap segment)
        {
            double totalLightnessValues = 0, averageOfSegment = 0;

            for (int pixelY = 0; pixelY < segment.Height; pixelY++)
            {
                for (int pixelX = 0; pixelX < segment.Width; pixelX++)
                {
                    var pixel = segment.GetPixel(pixelX, pixelY);
                    totalLightnessValues += pixel.GetBrightness() * Byte.MaxValue;
                }
            }

            //divide sum of lightness of segment's pixels by number of pixels
            averageOfSegment = totalLightnessValues / (segment.Height * segment.Width);
            return (Byte)averageOfSegment;
        }

        //splits the bitmap and returns it as segments of itself in a 2d array, the number of splits is relative to number of characters
        private Bitmap[,] SegmentImageAsMatrix(Bitmap bmp, int numberOfCharacters)
        {
            int segmentHeight = (int)bmp.Height / numberOfCharacters;
            int segmentWidth = (int)bmp.Width / numberOfCharacters;

            int arrayHeight = (int)bmp.Height / segmentHeight;
            int arrayWidth = (int)bmp.Width / segmentWidth;

            Bitmap[,] segments = new Bitmap[arrayHeight, arrayWidth];

            for (int col = 0; col < segments.GetLength(0); col++)
            {
                for (int row = 0; row < segments.GetLength(1); row++)
                {
                    Rectangle rectangle = new Rectangle((row * segmentWidth), (col * segmentHeight), segmentWidth, segmentHeight);
                    segments[col, row] = cropAtRect(bmp, rectangle);
                }
            }

            return segments;
        }
        //required for SegmentImageAsMatrix, this code crops the passed Bitmap to the size of the passed Rectangle
        public static Bitmap cropAtRect(Bitmap b, Rectangle r)
        {
            Bitmap nb = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(nb))
            {
                g.DrawImage(b, -r.X, -r.Y);
                return nb;
            }
        }
    }
}
