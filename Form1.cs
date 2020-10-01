using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymoUs
{
    public partial class Form1 : Form
    {
        // Anonymo Us by Ruan991 on Github
        // Open Source to learning

        string usr;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
            usr = Environment.UserName; // set string usr current windows user
            cur_user.Text = "User: " + usr; // hidden username textbox for debug
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xname = "991"; // ingame name
            string locat = "C:\\Users\\" + usr + "\\AppData\\LocalLow\\Innersloth\\Among Us\\playerPrefs"; // among us prefs location
            if (File.ReadAllText(locat).Contains(xname)) // if ingame name = 991 (xname)
            {
                string text = File.ReadAllText(locat);
                text = text.Replace(xname, "ㅤ"); // dont del the white space
                File.WriteAllText(locat, text); // change 991 (xname) to invisible name
                MessageBox.Show("Now you have no name!", "Anonymo Us", MessageBoxButtons.OK); // success message
            }
            else
            {
                MessageBox.Show("Have you changed your nickname to \"991\" and closed the game?", "error"); // error message if name doesnt match
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // X button
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ruan991"); // on icon click
        }

        // end

        // move window code

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // end
    }
}


// COME TO BRAZIL!!