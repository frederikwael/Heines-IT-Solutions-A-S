using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp
{
    public partial class BingoBoardWindow : Window
    {
        public BingoBoardWindow()
        {
            InitializeComponent();
        }


        private void GenerateBingoBoard(object sender, RoutedEventArgs e)
        {
            BingoGrid.Children.Clear();

            var board = GenerateBoard();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    var border = new Border
                    {
                        BorderThickness = new Thickness(1),
                        BorderBrush = Brushes.Black,
                        Background = Brushes.White,
                        Child = new TextBlock
                        {
                            Text = board[row][col]?.ToString() ?? "",
                            FontSize = 16,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            TextAlignment = TextAlignment.Center,
                            Foreground = Brushes.Black
                        }
                    };

                    BingoGrid.Children.Add(border);
                }
            }
        }

        private void BackToMainMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private List<List<int?>> GenerateBoard()
        {
            Random rand = new Random();
            var board = new List<List<int?>> { new List<int?>(), new List<int?>(), new List<int?>() };
            var columns = new List<List<int>>();

            for (int i = 0; i < 9; i++)
            {
                int min = i * 10 + 1;
                int max = (i == 8) ? 90 : i * 10 + 10;
                columns.Add(Enumerable.Range(min, max - min + 1).OrderBy(x => rand.Next()).Take(3).OrderBy(x => x).ToList());
            }

            for (int col = 0; col < 9; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    board[row].Add(columns[col].Count > row ? columns[col][row] : (int?)null);
                }
            }

            foreach (var row in board)
            {
                while (row.Count(x => x.HasValue) > 5)
                {
                    int index = rand.Next(0, 9);
                    if (row[index].HasValue)
                    {
                        row[index] = null;
                    }
                }
            }

            return board;
        }
    }
}
