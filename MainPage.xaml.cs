
using System;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0; 
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x + y);
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x - y);
        }
        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x * y);
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            PerformOperation((x, y) => x / y);
        }
        private void PerformOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(input1.Text, out double num1) && double.TryParse(input2.Text, out double num2))
            {
                double result = operation(num1, num2);
                resultLabel.Text = $"Sonuç: {result}";
            }
            else
            {
                resultLabel.Text = "Geçersiz giriş!";
            }
        }

    }

}


