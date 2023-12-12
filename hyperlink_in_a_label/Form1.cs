using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyperlink_in_a_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = "Visit our website";
            linkLabel.Location = new System.Drawing.Point(20, 20);
            linkLabel.AutoSize = true;
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel_LinkClicked);

            this.Controls.Add(linkLabel);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bbc.co.uk");
        }
    }
}
