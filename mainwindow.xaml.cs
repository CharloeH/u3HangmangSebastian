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

namespace u3HemanSebastian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random(1);
        System.IO.StreamReader streamReader = new System.IO.StreamReader("Words.txt");
        public MainWindow()
        {
            InitializeComponent(); 
               // System.IO.StreamReader streamReader = new System.IO.StreamReader("Words.txt");
                string[] Word = new string[6];
                string[] Guessed = new string[10];
                string GuessedLetter = "";
            Random random = new Random(1);
           
           
           /* while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if (line.Contains(RNG.ToString()))
                {
                    string WordUsed = line.Substring(line.IndexOf(RNG.ToString())+2, line.Length -2);
                    MessageBox.Show(WordUsed); 
                }

            }*/
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            int RNG = random.Next(1, 9);
            MessageBox.Show(RNG.ToString());
             while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if (line.Contains(RNG.ToString()))
                {
                    string WordUsed = line.Substring(line.IndexOf(RNG.ToString()) + 2, line.Length - 2);
                    MessageBox.Show(WordUsed);
                }

            }
        }
    }
    }
    

