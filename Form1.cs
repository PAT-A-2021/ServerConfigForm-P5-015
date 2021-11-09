using ServiceMtk_P1_20190140015;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_20190140015
{
    public partial class Form1 : Form
    {
        private ServiceHost Host; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));
            btnOn.Enabled = false;
            btnOff.Enabled = true;
            Host.Open();   
            labelStatus.Text = "Server : ON";
            labelKet.Text = "Click OFF to disabling server";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled  = true;
            btnOff.Enabled = false;
            Host.Close();
            labelStatus.Text = "Server : OFF";
            labelKet.Text = "Click ON to enabling server";
        }
    }
}
