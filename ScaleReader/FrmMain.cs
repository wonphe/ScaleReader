using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ScaleReader
{
    public partial class FrmMain : Form
    {
        private Rs232 _rs232;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ddlParity.SelectedIndex = 0;
            ddlStopbits.SelectedIndex = 1;
            ddlBaudrate.SelectedIndex = 0;

            ddlPort.DataSource = SerialPort.GetPortNames();
            if (ddlPort.Items.Count > 0)
            {
                ddlPort.SelectedIndex = 0;
            }
        }

        private static void Rs232_ExecuteResponse(string response)
        {
            SendKeys.Send(response);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == @"开始")
            {
                var port = Convert.ToString(ddlPort.SelectedItem);
                var baudrate = Convert.ToInt32(ddlBaudrate.SelectedItem);
                var databits = Convert.ToInt32(txtDatabits.Text.Trim());
                var parity = (Parity)ddlParity.SelectedIndex;
                var stopBits = (StopBits)ddlStopbits.SelectedIndex;

                if (ddlPort.Items.Count <= 0) return;

                _rs232 = new Rs232(port, baudrate, databits, parity, stopBits);
                _rs232.ExecuteResponse += Rs232_ExecuteResponse;

                btnStartStop.Text = @"停止";
                gbParams.Enabled = false;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                _rs232.ClosePort();
                _rs232 = null;
                btnStartStop.Text = @"开始";
                gbParams.Enabled = true;
            }
        }
    }
}
