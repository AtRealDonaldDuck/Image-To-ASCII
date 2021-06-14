using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UserInterface.UserControls
{
    public partial class AsciiStyle : UserControl
    {
        /// <summary>
        ///     A default asciistyle object
        /// </summary>
        public AsciiStyle()
        {
            InitializeComponent();

            var defaultCharList = new char[] { ' ', ',', '.', '-', '!', '$', '#', '@' };
            for (int i = 0; i < defaultCharList.Length; i++)
            {
                AddCharacter();
                grdCharactersPanel.Children[i].SetValue(TextBox.TextProperty, defaultCharList[i].ToString());
            }
        }

        //contains characters represantitive of the darkest brightness values to the lightest brightness values
        public char[] CharArray
        {
            //returns chars CharArray, returned in reverse order if _isGradientReversed == true
            get
            {
                var charList = new List<char>();
                foreach (TextBox item in grdCharactersPanel.Children)
                {
                    charList.Add(item.Text == "" ? ' ' : Char.Parse(item.Text));
                }
                if (_isGradientReversed)
                {
                    charList.Reverse();
                }
                return charList.ToArray();
            }
        }

        private void MenuItem_AddCharacter_Click(object sender, RoutedEventArgs e)
        {
            AddCharacter();
        }
        //Adds textbox to grdCharactersPanel, and sets up events to select text when focus is captured
        public void AddCharacter()
        {
            TextBox textBox = new TextBox() { TextAlignment = TextAlignment.Center, MaxLength = 1 };
            textBox.GotKeyboardFocus += SelectText;
            textBox.GotMouseCapture += SelectText;

            grdCharactersPanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            grdCharactersPanel.Children.Add(textBox);
            Grid.SetColumn(grdCharactersPanel.Children[grdCharactersPanel.Children.Count - 1], grdCharactersPanel.ColumnDefinitions.Count - 1);
        }
        //selects text of the sender
        private void SelectText(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void MenuItem_RemoveCharacter_Click(object sender, RoutedEventArgs e)
        {
            RemoveCharacter();
        }
        //removes a textbox from grdCharactersPanel, if number of textboxes within the panel is !> 1 error message appears
        public void RemoveCharacter()
        {
            if (grdCharactersPanel.ColumnDefinitions.Count > 1)
            {
                grdCharactersPanel.Children.RemoveAt(grdCharactersPanel.Children.Count - 1);
                grdCharactersPanel.ColumnDefinitions.RemoveAt(grdCharactersPanel.ColumnDefinitions.Count - 1);
            }
            else
            {
                //error message
                MessageBox.Show("You can not go below 1 character slot.");
            }
        }

        bool _isGradientReversed = false;
        //flips white to black gradient and sets _isGradientReversed to a value corresponding to the gradients position
        private void btnReverseGradient_Click(object sender, RoutedEventArgs e)
        {
            var blackHex = Colors.Black;
            var whiteHex = Colors.White;
            grdntStpLeft.Color = grdntStpLeft.Color == blackHex ? whiteHex : blackHex;
            grdntStpRight.Color = grdntStpRight.Color == blackHex ? whiteHex : blackHex;

            _isGradientReversed = _isGradientReversed ? false : true;
        }

        private void borderBlackToWhiteGradient_MakeReverseButtonVisible(object sender, MouseEventArgs e)
        {
            btnReverseGradient.Visibility = Visibility.Visible;
        }
        private void borderBlackToWhiteGradient_MakeReverseButtonInvisible(object sender, MouseEventArgs e)
        {
            btnReverseGradient.Visibility = Visibility.Collapsed;
        }
    }
}
