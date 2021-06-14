using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UserInterface.UserControls
{
    public partial class UserImageBox : UserControl
    {
        public UserImageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The last image uploaded by the user
        /// </summary>
        public ImageSource UserImage
        {
            get => imgUploadedImage.Source;
            set => imgUploadedImage.Source = value;
        }
        /// <summary>
        /// The name of the last image the user uploaded
        /// </summary>
        public string ImageName
        {
            get => txtBoxImageName.Text;
            set => txtBoxImageName.Text = value;
        }

        //opens file browser ,assigns the image which the user has selected to UserImage and assigns UserImage's name to ImageName. finally SwitchLayoud(false) is called
        private void btnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "ImageFiles(*.jpg, *.png)|*.jpg; *.jpeg; *.png|AllFiles(*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                UserImage = (ImageSource)new ImageSourceConverter().ConvertFromString(openFileDialog.FileName);
                //assign image name userImage's name but ommits the images path
                ImageName = UserImage.ToString().Substring(UserImage.ToString().LastIndexOf(@"/") + 1);
                SwitchLayout(false);
            }
        }



        private void imgUploadedImage_ContextMenu_RemoveImage_Click(object sender, RoutedEventArgs e)
        {
            ClearUserUpload();
        }

        //changes the visibility of multiple elements to switch between UI where an image is uploaded and one where an image is yet to be uploaded
        private void SwitchLayout(bool switchToUploadImageLayout)
        {
            txtBoxImageName.Visibility = switchToUploadImageLayout ? Visibility.Collapsed : Visibility.Visible;
            imgUploadedImage.Visibility = switchToUploadImageLayout ? Visibility.Collapsed : Visibility.Visible;
            btnUploadImage.Visibility = switchToUploadImageLayout ? Visibility.Visible : Visibility.Collapsed;
            if (switchToUploadImageLayout)
            {
                btnRemoveUploadedImage.Visibility = Visibility.Collapsed;
            }
        }
        //shows the UI to remove the uploaded image
        private void imgUploadedImage_MouseEnter(object sender, MouseEventArgs e)
        {
            imgUploadedImage.Opacity = 0.7;
            btnRemoveUploadedImage.Visibility = Visibility.Visible;
        }
        //hides the UI to remove the uploaded image
        private void imgUploadedImage_MouseLeave(object sender, MouseEventArgs e)
        {
            imgUploadedImage.Opacity = 1;
            btnRemoveUploadedImage.Visibility = Visibility.Collapsed;
        }

        private void btnRemoveUploadedImage_Click(object sender, RoutedEventArgs e)
        {
            ClearUserUpload();
        }

        //nullifies UserImage and ImageName thus clearing the uploaded image from UI, finally SwitchLayout(true) is called
        private void ClearUserUpload()
        {
            UserImage = null;
            ImageName = null;
            SwitchLayout(true);
        }
    }
}
