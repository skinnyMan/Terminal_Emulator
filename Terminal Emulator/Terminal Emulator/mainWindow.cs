using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Terminal_Emulator.Properties;
using System.IO.Ports;

namespace Terminal_Emulator
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPort.PortName = Settings.Default["comPort"].ToString();
            comPort.BaudRate = int.Parse(Settings.Default["baudRate"].ToString());
            comPort.Parity = (Parity)Enum.Parse(typeof(Parity), Settings.Default["parity"].ToString());
            comPort.DataBits = int.Parse(Settings.Default["dataBits"].ToString());
            comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Settings.Default["stopBits"].ToString());
        }

        private void bSend_Click(object sender, EventArgs e)
        {

        }

        private void bClearRxText_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm serialOptionsForm = new settingsForm();
            serialOptionsForm.ShowDialog();
            comPort.PortName = Settings.Default["comPort"].ToString();
            comPort.BaudRate = int.Parse(Settings.Default["baudRate"].ToString());
            comPort.Parity = (Parity)Enum.Parse(typeof(Parity), Settings.Default["parity"].ToString());
            comPort.DataBits = int.Parse(Settings.Default["dataBits"].ToString());
            comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Settings.Default["stopBits"].ToString());
        }

        
    }
}
