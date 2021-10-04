/// HomeWork 5(Graded Assignment)    
/// File Name: HomeWork5Week5 (Part 1)
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
///This is the body mass index is calculated as a person’s weight (in pounds) times 720, divided by the square of 
///the person’s height (in inches).Included is  a color element of blue (below), green(within), 
///yellow (above).




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWorkWeek5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BMIButton_Click(object sender, RoutedEventArgs e)
        {
            int Weight, Height, BMI;

            Weight = int.Parse(WeightTextBox.Text);                    
            Height = int.Parse(WeightTextBox.Text);
          
            BMI = ((Weight * 720) / Height*Height);


            if (BMI < 15)
            {
                MessageBox.Show(" You are under weight not healthy!");
                TempCanvas.Background = Brushes.Blue;
            }
            else if (BMI >= 15 && BMI <= 26)
            {

                MessageBox.Show(" You're weight is right, good job!");
                TempCanvas.Background = Brushes.Green;
            }
            else
            {
                MessageBox.Show(" Whoops you are overweight time to cut back!");
                TempCanvas.Background = Brushes.Yellow;
            }
         

        }
    }
}
