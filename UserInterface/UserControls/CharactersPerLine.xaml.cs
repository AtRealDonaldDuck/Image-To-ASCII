using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace UserInterface.UserControls
{
    public partial class CharactersPerLine : UserControl
    {
        public CharactersPerLine()
        {
            InitializeComponent();
        }

        //ensures only numeric characters can be entered
        private void txtBoxCharactersPerLineInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
