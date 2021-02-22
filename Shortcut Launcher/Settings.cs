using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Shortcut_Launcher
{
    public partial class Settings : Form
    {
        private Form1 form1;
        public Settings(Form1 f)
        {
            InitializeComponent();
            form1 = f;
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
                    numericUpDown1.Value = Convert.ToDecimal(key.GetValue("height"));
                key.Close();
            }

            textBox1.Text = eshop;
            textBox2.Text = plus4u;
            textBox3.Text = pc1;
            textBox4.Text = efresh;

            textBox8.Text = paradoseis;
            textBox7.Text = paradoseisfresh;

            textBox12.Text = kleisimo;
            textBox11.Text = analush;
            textBox10.Text = epistrofes;
            textBox9.Text = kath;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\e-ShopShortcuts");
            key.SetValue("eshop", textBox1.Text);
            key.SetValue("plus4u", textBox2.Text);
            key.SetValue("pc1", textBox3.Text);
            key.SetValue("efresh", textBox4.Text);

            key.SetValue("paradoseis", textBox8.Text);
            key.SetValue("paradoseisfresh", textBox7.Text);

            key.SetValue("kleisimo", textBox12.Text);
            key.SetValue("analush", textBox11.Text);
            key.SetValue("epistrofes", textBox10.Text);
            key.SetValue("kath", textBox9.Text);
            key.SetValue("height", numericUpDown1.Value);
            key.Close();
            this.Hide();
            Properties.Settings.Default.Height = numericUpDown1.Value;
            form1.InitializeSettings();
            Properties.Settings.Default.Save();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox1.Text = file;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox2.Text = file;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox3.Text = file;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox4.Text = file;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox8.Text = file;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox7.Text = file;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox12.Text = file;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox11.Text = file;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox10.Text = file;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = folderBrowserDialog1.SelectedPath;
                textBox9.Text = file;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            form1.ChangeHeight(Convert.ToDecimal(numericUpDown1.Value));
        }
    }
}
