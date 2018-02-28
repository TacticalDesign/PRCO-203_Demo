﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for Youth_ChallengeFeed.xaml
    /// </summary>
    public partial class Youth_ChallengeFeed : UserControl
    {
        public Youth_ChallengeFeed()
        {
            InitializeComponent();
        }

        public void Load()
        {
            spFeed.Children.Clear();

            ((MainWindow)Application.Current.MainWindow).TitleLabel = "Challenge Feed";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadStringCompleted += (ss, ee) =>
                {
                    Challenge[] challenges = JsonConvert.DeserializeObject<Challenge[]>(ee.Result);
                    foreach (Challenge challenge in challenges)
                    {
                        spFeed.Children.Add(challenge);
                    }
                };
                wc.DownloadStringAsync(new Uri("http://localhost/DP/api/GetChallenges.php?find=all"));
            }
        }
    }
}
