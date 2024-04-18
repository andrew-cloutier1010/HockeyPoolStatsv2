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
    public partial class SettingsUi : Form
    {
        public SettingsUi()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsUi_Load(object sender, EventArgs e)
        {

            Settings settings = new Settings();
            txt_ApiUri.Text = settings.ApiUrl;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Settings.SaveSetting("ApiUri", txt_ApiUri.Text);

            this.Close();

        }
    }
}
