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
    /// Interaction logic for Youth_ChallengePage.xaml
    /// </summary>
    public partial class Youth_ChallengePage : UserControl
    {
        public Youth_ChallengePage(string ID, string name, string reward, string image, string description, string[] skills, string[] locations)
        {
            InitializeComponent();

            ((MainWindow)Application.Current.MainWindow).TitleLabel = name + " (" + reward + ")";

            if (skills.Length > 0)
                rbSkill1.Content = skills[0];
            if (skills.Length > 1)
                rbSkill2.Content = skills[1];
            if (skills.Length > 2)
                rbSkill3.Content = skills[2];

            tblDescription.Text = description;

            if (locations.Length > 0)
                lblLocation1.Content = locations[0];
            if (locations.Length > 1)
                lblLocation2.Content = locations[1];
            if (locations.Length > 2)
                lblLocation3.Content = locations[2];
        }
    }
}