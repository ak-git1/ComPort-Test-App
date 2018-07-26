using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Ak.ComPort.Test.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort($"COM{(int)ComPortNumber.Value}", 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write(DataTxt.Text);
                port.Close();

                MessageBox.Show("Successfully sent data to the COM port.");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}");
            }            
        }
    }
}
