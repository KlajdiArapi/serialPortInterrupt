using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace serialPortInterrupt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMex.LostFocus += txtMex_LostFocus;
            txtMex.GotFocus += txtMex_GotFocus;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetPortsIn_Click(object sender, EventArgs e)
        {
            try
            {
                cbIn.Items.AddRange(SerialPort.GetPortNames());
                btnGetPortsIn.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Errore " + ex);
            }
        }

        private void btnGetPortOut_Click(object sender, EventArgs e)
        {
            try
            {
                cbOut.Items.AddRange(SerialPort.GetPortNames());
                btnGetPortOut.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Errore " + ex);
            }
        }

        private void txtMex_Click(object sender, EventArgs e)
        {
            txtMex.Clear();
            txtMex.ForeColor = Color.Black;
        }


        //txt data type your text here... visible
        private void txtMex_LostFocus(object sender, EventArgs e)
        {
            if (txtMex.Text == "")
            {
                txtMex.Text = "Enter a message";
                txtMex.ForeColor = Color.DarkGray;
            }
        }

        private void txtMex_GotFocus(object sender, EventArgs e)
        {
            if (txtMex.Text == "Enter a message")
            {
                txtMex.Text = "";
                txtMex.ForeColor = Color.Black;
            }
        }

        private void txtMex_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send()
        {
            //if (serialPort2.IsOpen == false)
            //{
                //serialPort2.Open();
                //serialPort2.Write(txtMex.Text);
                Chat.Items.Add("me: "+ txtMex.Text);
            //}
        }

        string output = "";
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            output += serialPort1.ReadExisting();

            if (output.EndsWith("%?"))
            {
                this.Invoke(new Action(() =>
                {
                        Chat.Items.Add(output);
                }));

                output = "";
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            txtMex.Clear();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //if (!(serialPort1.IsOpen))
            //{
            //    serialPort1.Open();
            //    btnSwitch.Text = "ON";
            //    btnSwitch.ForeColor = Color.Green;


            //}
            //else
            //{
            //    btnSwitch.Text = "OFF";
            //    btnSwitch.ForeColor = Color.Red;
            //    serialPort1.Close();
            //}
        }

        private void txtMex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Send();
                txtMex.Clear();
            }
        }

        private void btnGetMex_Click(object sender, EventArgs e)
        {
            Chat.Items.Add("Padre pio: Ciao");
        }
    }
}
