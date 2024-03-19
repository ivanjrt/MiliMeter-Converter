using System;
using System.Windows;


namespace MillimetersConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConvertToCentimeters_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(mmInput.Text, out double millimeters))
            {
                decimal millimetersDecimal = (decimal)millimeters;
                decimal centimeters = millimetersDecimal / 10m;
                decimal truncatedCentimeters = Math.Truncate(centimeters * 100) / 100; // Truncate to two decimal places
                cmResult.Text = $"Centimeters: {truncatedCentimeters} 📋";
                CopyToClipboard(truncatedCentimeters.ToString());
            }
            else
            {
                cmResult.Text = "Invalid input. Please enter a valid number.";
            }
        }

        private void ConvertToInches_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(mmInput.Text, out double millimeters))
            {
                decimal millimetersDecimal = (decimal)millimeters;
                decimal inches = millimetersDecimal / 25.4m;
                decimal truncatedInches = Math.Truncate(inches * 100) / 100; // Truncate to two decimal places
                inchesResult.Text = $"Inches: {truncatedInches} 📋";
                CopyToClipboard(truncatedInches.ToString());
            }
            else
            {
                inchesResult.Text = "Invalid input. Please enter a valid number.";
            }
        }
        private void CopyToClipboard(string value)
        {
            Clipboard.SetText(value);
        }

        private void ResetAll_Click(object sender, RoutedEventArgs e)
        {
            mmInput.Text = null;
            cmResult.Text = null;
            inchesResult.Text = null;
        }
    }
}