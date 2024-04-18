using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyPoolStatsv2
{
    public partial class SetPlayoffYear : Form
    {
        public SetPlayoffYear()
        {
            InitializeComponent();

        }

        private void SetPlayoffYear_Load(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            textBox1.Text = settings.PlayoffYear;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.SaveSetting("PlayoffYear", textBox1.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
