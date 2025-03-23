using System;
using System.Windows;
using System.Windows.Controls;

namespace wpfExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            // Определяем, какой RadioButton выбран
            // и в зависимости от этого расчитываем нужную формулу
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(((ComboBoxItem)R1ComboF.SelectedItem).Content);
                this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
            }
            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(((ComboBoxItem)R2ComboF.SelectedItem).Content);
                this.Title = "Ответ: " + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
            }
            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextB.Text);
                double c = Convert.ToDouble(((ComboBoxItem)R3ComboC.SelectedItem).Content);
                double d = Convert.ToDouble(((ComboBoxItem)R3ComboD.SelectedItem).Content);
                this.Title = "Ответ: " + (c * a * a + d * b * b).ToString("F");
            }
            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R4TextA.Text);
                double d = Convert.ToDouble(R4TextD.Text);
                double c = Convert.ToDouble(((ComboBoxItem)R4ComboC.SelectedItem).Content);
                double res = 1;
                for (int i = 0; i < d; i++)
                {
                    res = res * (c + a) + 1;
                }
                this.Title = "Ответ: " + res.ToString("F");
            }
        }
    }
}