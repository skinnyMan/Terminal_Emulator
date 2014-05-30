using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Terminal_Emulator.Properties;

namespace Terminal_Emulator
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            updatePorts();
            this.cmbPortName.Text = Settings.Default["comPort"].ToString();
            this.cmbBaudRate.Text = Settings.Default["baudRate"].ToString();
            this.cmbParity.Text = Settings.Default["parity"].ToString();
            this.cmbDataBits.Text = Settings.Default["dataBits"].ToString();
            this.cmbStopBits.Text = Settings.Default["stopBits"].ToString();
            
        }

        private void updatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings.Default["comPort"] = cmbPortName.Text;
            Settings.Default["baudRate"] = cmbBaudRate.Text;
            Settings.Default["parity"] = cmbParity.Text;
            Settings.Default["dataBits"] = cmbDataBits.Text;
            Settings.Default["stopBits"] = cmbStopBits.Text;
            Settings.Default.Save();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
