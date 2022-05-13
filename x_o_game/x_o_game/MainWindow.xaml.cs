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

namespace x_o_game
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
        public char[,] mat = new char[3, 3];
       
        public int  count = 0;
        private void init()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = '?';
                }
            }
        }
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            //char c = mat[0, 0];
            //  MessageBox.Show(c.ToString());
            if (count == 0)
                init();
            Button b = e.OriginalSource as Button;
            int row = (int)b.GetValue(Grid.RowProperty);
            int col = (int)b.GetValue(Grid.ColumnProperty);
            if (b.Content.ToString()=="?")
            { 
            if (count % 2 == 0)
                { 
                b.Content = "x";
                mat[row,col] = 'x';
                }
                else
                {
                b.Content = "o";
                 mat[row, col] = 'o';
                }
            }
            count++;
            if (count > 4)
                if (checkWinner())
                { 
                    MessageBox.Show("winnnnnn");
                }
            else
               if(count==9)
                    MessageBox.Show("xxxxxxxxxxxx");
        }

        private bool checkWinner()
        {
          //  Grid board = sender as Grid;
            if (mat[0,0]  == mat[0,1] && mat[0, 0] == mat[0, 2] && mat[0,0]!='?')
                return true;
            if (mat[0, 0] == mat[1, 0] && mat[0, 0] == mat[2, 0] && mat[0, 0] != '?')
                return true;
            if (mat[0, 0] == mat[1, 1] && mat[0, 0] == mat[2, 2] && mat[0, 0] != '?')
                return true;
            if (mat[2, 2] == mat[2, 0] && mat[2,2] == mat[2, 1] && mat[2, 2] != '?')
                return true;
            if (mat[2, 2] == mat[1, 2] && mat[2, 2] == mat[0, 2] && mat[2, 2] != '?')
                return true;
            if (mat[0, 1] == mat[1, 1] && mat[0, 1] == mat[2, 1] && mat[0, 1] != '?')
                return true;
            if (mat[1, 0] == mat[1, 1] && mat[1, 0] == mat[1, 2] && mat[1, 0] != '?')
                return true;
            if (mat[0, 2] == mat[1, 1] && mat[0, 2] == mat[2, 0] && mat[1, 1] != '?')
                return true;
            return false;
        }
  
    }
}
