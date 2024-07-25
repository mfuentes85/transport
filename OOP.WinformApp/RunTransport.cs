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
    public partial class RunTransport : Form
    {
        Transport _transport;
        public RunTransport()
        {
            InitializeComponent();
        }

        public RunTransport(Transport transport) : this() 
        {
            _transport = transport;
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            int distance= int.Parse(distanceTextBox.Text);
            _transport.Run(distance); 
            Close();
        }
    }
}
