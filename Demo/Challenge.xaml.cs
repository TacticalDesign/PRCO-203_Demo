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
using Newtonsoft.Json;

namespace Demo
{
    /// <summary>
    /// Interaction logic for Challenge.xaml
    /// </summary>
    public partial class Challenge : UserControl
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string ChallengeName
        {
            set
            {
                lblName.Content = value;
            }
            get
            {
                return lblName.Content.ToString();
            }
        }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("skills")]
        public string[] Skills
        {
            set
            {
                if (value.Length > 0)
                    rbSkill1.Content = value[0];
                if (value.Length > 1)
                    rbSkill2.Content = value[1];
                if (value.Length > 2)
                    rbSkill3.Content = value[2];
            }
            get
            {
                return new string[] { rbSkill1.Content.ToString(), rbSkill2.Content.ToString(), rbSkill3.Content.ToString() };
            }
        }

        [JsonProperty("description")]
        public string Description
        {
            set
            {
                tblDescription.Text = value;
            }
            get
            {
                return tblDescription.Text;
            }
        }

        [JsonProperty("reward")]
        public string Reward
        {
            set
            {
                lblPoints.Content = value;
            }
            get
            {
                return lblPoints.Content.ToString();
            }
        }

        [JsonProperty("location1")]
        public string Location1 { get; set; }

        [JsonProperty("location2")]
        public string Location2 { get; set; }

        [JsonProperty("location3")]
        public string Location3 { get; set; }


        public Challenge()
        {
            InitializeComponent();
        }

        private void UserControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).spContent.Children.Clear();
            ((MainWindow)Application.Current.MainWindow).spContent.Children.Add(new Youth_ChallengePage(ID, ChallengeName, Reward,
                Image, Description, Skills, new string[] { Location1, Location2, Location3 }));
        }
    }
}
