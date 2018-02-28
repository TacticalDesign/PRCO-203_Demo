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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TitleLabel
        {
            get
            {
                return lblTitle.Content.ToString();
            }
            set
            {
                lblTitle.Content = value;
            }
        }

        Youth_ChallengeFeed youth_ChallengeFeed = new Youth_ChallengeFeed();

        public MainWindow()
        {
            InitializeComponent();

            spContent.Children.Add(youth_ChallengeFeed);
            youth_ChallengeFeed.Load();
        }

        private void btnChallengeFeed_Click(object sender, RoutedEventArgs e)
        {
            spContent.Children.Clear();
            spContent.Children.Add(youth_ChallengeFeed);
            youth_ChallengeFeed.Load();
        }
    }
}
