using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Mine
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int[,] doubleArray = GenerateArray(10, 10); 
            DisplayArray(doubleArray);
            bool canDig = CanDigTunnel(doubleArray); 
            DisplayResult(canDig);
        }

        private int[,] GenerateArray(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = random.Next(10); 
                }
            }
            return result;
        }

        private void DisplayArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Label label = new Label
                    {
                        Content = array[i, j].ToString(),
                        Background = new SolidColorBrush(Color.FromRgb((byte)(array[i, j] * 25), (byte)(255 - array[i, j] * 25), 0)),
                        Margin = new Thickness(j * 30, i * 30, 0, 0)
                    };
                    MainCanvas.Children.Add(label); 
                }
            }
        }

        private bool CanDigTunnel(int[,] array)
        {
            
            return true; 
        }

        private void DisplayResult(bool canDig)
        {
            MessageBox.Show(canDig ? "Туннель прокопать можно." : "Туннель прокопать нельзя.");
        }
    }
}
