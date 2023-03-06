using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFirstGUIApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int result;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b= Int32.Parse(textBox2.Text);
             result = a+b;
            textBlock.Text=result.ToString();
            decimalRadioButton.IsChecked = true;

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
             result = a - b;
            textBlock.Text = result.ToString();
            decimalRadioButton.IsChecked = true;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
             result = a * b;
            textBlock.Text = result.ToString();
            decimalRadioButton.IsChecked = true;
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            if (result != 0)
                result = a / b;
            else textBlock.Text = "Ne moze se dijeliti s 0";
            textBlock.Text = result.ToString();
            decimalRadioButton.IsChecked= true;
        }

        private void decimalRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (decimalRadioButton.IsChecked == true)
            {
                textBlock.Text = Convert.ToString(result, 10);
                
            }
        }

        private void hexadecimalRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (hexadecimalRadioButton.IsChecked == true)
            {
                textBlock.Text = Convert.ToString(result, 16);
            }
        }

        private void octalRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (octalRadioButton.IsChecked == true)
            {
                textBlock.Text = Convert.ToString(result, 8);
            }
        }

        private void binaryRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (binaryRadioButton.IsChecked == true)
            {
                textBlock.Text = Convert.ToString(result, 2);
            }
        }
    }
}