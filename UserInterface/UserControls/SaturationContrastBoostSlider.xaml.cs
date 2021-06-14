using System.Windows;
using System.Windows.Controls;

namespace UserInterface.UserControls
{
    public partial class SaturationContrastBoostSlider : UserControl
    {
        public SaturationContrastBoostSlider()
        {
            InitializeComponent();
            DataContext = this.DataContext;
        }

        public int Value { get; private set; }

        private void sldrSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Value = (int)sldrSlider.Value;
        }
    }
}
