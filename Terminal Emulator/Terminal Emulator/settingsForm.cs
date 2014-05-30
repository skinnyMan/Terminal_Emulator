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
            this.cmbBaudRate.SelectedValue = Settings.Default["comPort"];
            this.cmbBaudRate.SelectedValue = Settings.Default["comPort"];
            this.cmbParity.SelectedValue = Settings.Default["baudRate"];
            this.cmbDataBits.SelectedValue = Settings.Default["dataBits"];
            this.cmbStopBits.SelectedValue = Settings.Default["stopBits"];
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
            Settings.Default["comPort"] = cmbPortName.SelectedIndex;
            Settings.Default["baudRate"] = cmbBaudRate.SelectedIndex;
            Settings.Default["parity"] = cmbParity.SelectedIndex;
            Settings.Default["dataBits"] = cmbDataBits.SelectedIndex;
            Settings.Default["stopBits"] = cmbStopBits.SelectedIndex;
            Settings.Default.Save();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            
        }

    }
}
