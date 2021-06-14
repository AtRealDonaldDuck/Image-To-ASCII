using ImageToAsciiClassLibrary;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UserInterface
{
    public partial class MainWindow : Window
    {
        public int NumberOfCharactersPerLine { get => int.Parse(usrCtrlCharactersPerLine.txtBoxCharactersPerLineInput.Text); }
        public char[] CharListFromDarkToLight { get => usrCtrlAsciiStyle.CharArray; }
        public ImageSource UserUploadedImage { get => usrCtrlUserImageBox.imgUploadedImage.Source; }
        public bool MoreOptionsEnabled { get => stkPnlCollapsableStackPanel.Visibility == Visibility.Collapsed ? false : true; }

        public MainWindow()
        {
            InitializeComponent();
        }
        //Open File Dialog and return the file user selected
        private Bitmap getImageFromUser()
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "All Files(*.*)|*.*|Image Files(*.jpeg,*.jpg,*.png)|*.jpeg;*.jpg;*.png"
            };
            openFileDialog.ShowDialog();

            return new Bitmap(openFileDialog.FileName);
        }

        private static Bitmap BitmapSourceToBitmap(BitmapSource bitmapSource)
        {
            Bitmap bmp;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();

                enc.Frames.Add(BitmapFrame.Create(bitmapSource));
                enc.Save(outStream);
                bmp = new Bitmap(outStream);
            }

            return bmp;
        }

        //alternative to BitmapSourceToBitmap
        /*Bitmap GetBitmap(BitmapSource source)
        {
            
            Bitmap bmp = new Bitmap(width: source.PixelWidth, height: source.PixelHeight, format: System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            BitmapData data = bmp.LockBits(
              new Rectangle(System.Drawing.Point.Empty, bmp.Size),
              ImageLockMode.WriteOnly,
              System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            source.CopyPixels(
              Int32Rect.Empty,
              data.Scan0,
              data.Height * data.Stride,
              data.Stride);
            bmp.UnlockBits(data);
            return bmp;
        }*/

        //ensures necessary fields are filled then converts the users image into an ASCII art image and prints it in the output textbox
        private void btnConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserUploadedImage == null || NumberOfCharactersPerLine <= 0)
            {
                MessageBox.Show("Ensure all necessary fields have been filled before attempting to convert an image to ASCII", "Error", MessageBoxButton.OK);
            }
            else
            {
                var asciiStyle = new AsciiStyle(CharListFromDarkToLight);
                Bitmap bitmap = BitmapSourceToBitmap((BitmapSource)UserUploadedImage);
                if (MoreOptionsEnabled)
                {
                    ApplyExtraOptions(ref bitmap);
                }

                txtBoxOutputAscii.Text = new ImageToAscii().FromBitmap(bitmap, NumberOfCharactersPerLine, asciiStyle);
            }
        }

        //apply the options within the extra options sliding menu
        private void ApplyExtraOptions(ref Bitmap bitmap)
        {
            bitmap = SetContrast(bitmap, usrCtrlSaturationContrastBoostSlider.Value);
        }

        //flips the visibility of the extra options sliding menu
        private void btnToggleCollapsableStackPanelVisibility_Click(object sender, RoutedEventArgs e)
        {
            bool flag = stkPnlCollapsableStackPanel.Visibility == Visibility.Collapsed;
            stkPnlCollapsableStackPanel.Visibility = flag ? Visibility.Visible : Visibility.Collapsed;
            btnToggleCollapsableStackPanelVisibility.Content = flag ? "Show Less ▲" : "Show More ▼";
        }

        //sets images contrast in image processing before doing the Ascii art conversion, threshold must be between -100 and 100
        private static Bitmap SetContrast(Bitmap bmp, int threshold)
        {
            var contrast = Math.Pow((100.0 + threshold) / 100.0, 2);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var oldColor = bmp.GetPixel(x, y);
                    var red = ((((oldColor.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var green = ((((oldColor.G / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var blue = ((((oldColor.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;

                    var newColor = System.Drawing.Color.FromArgb(oldColor.A, (int)red, (int)green, (int)blue);
                    bmp.SetPixel(x, y, newColor);
                }
            }
            return bmp;
        }

        //changes the font size of the text box depending on users input
        //(ctrl+oemPlus = zoom in, ctrl+oemMinus = zoom out)
        private void txtBoxOutputAscii_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (new KeyGesture(Key.OemPlus, ModifierKeys.Control).Matches(sender, e))
            {
                txtBoxOutputAscii.FontSize += 1;
            }
            else if (new KeyGesture(Key.OemMinus, ModifierKeys.Control).Matches(sender, e))
            {
                if (txtBoxOutputAscii.FontSize > 1)
                {
                    txtBoxOutputAscii.FontSize -= 1;
                }
            }
        }
    }
}