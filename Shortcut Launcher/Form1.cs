using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Win32;

namespace Shortcut_Launcher
{

    public partial class Form1 : Form
    {
        string eshop = "";
        string plus4u = "";
        string efresh = "";
        string pc1 = "";
        string paradoseis = "";
        string paradoseisfresh = "";
        string epistrofes = "";
        string analush = "";
        string kleisimo = "";
        string kath = "";
        string height;
        Settings _settings;

        public Form1()
        {
            InitializeComponent();
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\e-ShopShortcuts");
            if (key != null)
            {
                if (key.GetValue("eshop") != null)
                    eshop = key.GetValue("eshop").ToString();
                if (key.GetValue("plus4u") != null)
                    plus4u = key.GetValue("plus4u").ToString();
                if (key.GetValue("efresh") != null)
                    efresh = key.GetValue("efresh").ToString();
                if (key.GetValue("pc1") != null)
                    pc1 = key.GetValue("pc1").ToString();
                if (key.GetValue("paradoseis") != null)
                    paradoseis = key.GetValue("paradoseis").ToString();
                if (key.GetValue("paradoseisfresh") != null)
                    paradoseisfresh = key.GetValue("paradoseisfresh").ToString();
                if (key.GetValue("epistrofes") != null)
                    epistrofes = key.GetValue("epistrofes").ToString();
                if (key.GetValue("analush") != null)
                    analush = key.GetValue("analush").ToString();
                if (key.GetValue("kleisimo") != null)
                    kleisimo = key.GetValue("kleisimo").ToString();
                if (key.GetValue("kath") != null)
                    kath = key.GetValue("kath").ToString();
                if (key.GetValue("height") != null)
                {
                    height = key.GetValue("height").ToString();
                    //this.Left = Convert.ToInt32(height);
                    this.Location = new System.Drawing.Point(Convert.ToInt32(height), 0);
                }

                key.Close();
            }

            this.ChangeHeight(this.Height);
        }

        public void ChangeHeight(decimal value)
        {
            
            this.Left = Convert.ToInt32(value);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            _settings = new Settings(this);
            _settings.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(eshop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(plus4u);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pc1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(efresh);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(paradoseis);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(paradoseisfresh);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(kleisimo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(analush);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(epistrofes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(kath);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }


        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Height = 5;
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.Height = 81;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ChangeHeight(this.Height);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Height = 5;
        }
    }
}
