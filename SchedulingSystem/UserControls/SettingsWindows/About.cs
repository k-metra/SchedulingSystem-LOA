using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem.UserControls.SettingsWindows
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = linkLabel1.Text,
                UseShellExecute = true
            };

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(info);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = linkLabel2.Text,
                UseShellExecute = true
            };

            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start(info);
        }
    }
}
