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

            txTextBox.BackColor = Settings.Default.backColor;
            rxTextBox.BackColor = Settings.Default.backColor;
            txTextBox.ForeColor = Settings.Default.foreColor;
            rxTextBox.ForeColor = Settings.Default.foreColor;
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Write(txTextBox.Text);
                txTextBox.Clear();
            }
            else
                rxTextBox.AppendText("Port Closed");
        }

        private void bClearRxText_Click(object sender, EventArgs e)
        {
            txTextBox.Clear();
            rxTextBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Close();
            }
            this.Close();
        }

        private string receivedString;
        private void comPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            receivedString = comPort.ReadExisting();
            this.Invoke(new EventHandler(displayText));
        }

        private void displayText(object o, EventArgs e)
        {
            rxTextBox.AppendText(receivedString);
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

        private void openComPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!comPort.IsOpen)
            {
                comPort.Open();
                rxTextBox.Text = "Port Opened\n";
            }
            else
            {
                rxTextBox.Text = "Port Busy\n";
            }
        }

        private void txTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (comPort.IsOpen && e.KeyData == Keys.Enter)
            {
                comPort.Write(txTextBox.Text);
                txTextBox.Clear();
            }
        }

        private void closeComPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Close();
            }
            rxTextBox.Text = "Port Closed\n";
        }

        private void rxTextBox_TextChanged(object sender, EventArgs e)
        {
            rxTextBox.ScrollToCaret();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txTextBox.BackColor = colorDialog.Color;
                rxTextBox.BackColor = colorDialog.Color;
                Settings.Default["textColor"] = colorDialog.Color;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txTextBox.ForeColor = colorDialog.Color;
                rxTextBox.ForeColor = colorDialog.Color;
                Settings.Default["foreColor"] = colorDialog.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
