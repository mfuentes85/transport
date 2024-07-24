using AutoTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.WinformApp
{
    public partial class RechargeGas : Form
    {
        private Transport _transport;

        public RechargeGas()
        {
            InitializeComponent();
        }

        public RechargeGas(Transport transport) : this()
        {
            trackBar1.Maximum = transport.LtsCapacity;
            trackBar1.Minimum = 0;
            trackBar1.Value = 0;
            ltsLabel.Text = $"{trackBar1.Value} Litros";
            _transport = transport;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _transport.Lts=trackBar1.Value;
            Close();
        }

        private void RechargeGas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ltsLabel.Text = $"{trackBar1.Value} Litros";
        }
    }
}
