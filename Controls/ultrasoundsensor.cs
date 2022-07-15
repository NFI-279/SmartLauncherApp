using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace Artemis
{
    public partial class ultrasoundsensor : UserControl
    {
        string serialData;
        sbyte pozA, pozB, pozC, pozD, pozE, pozF, pozG, pozH, pozI;
        string WorkMode;
        string senzorUltrasunet, AvailableWater, WaterOut, VolumeWaterLeft, pompaRunning, TankCapacity;
        double WaterTankCapacity;
        int pompaIsRunning;
        string sendData = "";
        public ultrasoundsensor()
        {
            InitializeComponent();
            ToggleWaterPump.Enabled = false;
            ToggleWaterPump.Checked = false;
            shadowLabel11.Location = new Point(25, 167); shadowLabel12.Location = new Point(358, 167); shadowLabel13.Location = new Point(458, 167);
            shadowLabel16.Location = new Point(25, 247); shadowLabel20.Location = new Point(358, 248); shadowLabel15.Location = new Point(458, 247);
        }

        private void comboBoxPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxPortList.Text;
        }

        private void butonDeschiderePort_CheckedChanged(object sender)
        {
            if (butonDeschiderePort.Checked)
            {
                try
                {
                    serialPort1.PortName = comboBoxPortList.Text;
                    serialPort1.BaudRate = Convert.ToInt32(ComboBoxBaudRate.Text);
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    { 
                        labelPortState.Text = "OPEN";
                        butonDeschiderePort.Checked = true;
                        shadowLabel20.Text = "3.00";
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    labelPortState.Text = "CLOSED";
                    butonDeschiderePort.Checked = false;
                    shadowLabel20.Text = "UNKNOWN";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skeetButton13_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxPortList_DropDown(object sender, EventArgs e)
        {
            string[] listaPort = SerialPort.GetPortNames();
            comboBoxPortList.Items.Clear();
            comboBoxPortList.Items.AddRange(listaPort);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ToggleWaterPump_CheckedChanged(object sender)
        {
        }

        private void shadowLabel17_Click(object sender, EventArgs e)
        {

        }

        private void shadowLabel16_Click(object sender, EventArgs e)
        {

        }

        private void shadowLabel12_Click(object sender, EventArgs e)
        {

        }

        private void shadowLabel13_Click(object sender, EventArgs e)
        {

        }

        private void skeetGroupBox3_Enter(object sender, EventArgs e)
        {
            

        }

        private void skeetButton6_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) // Textbox-ul accepta doar numere
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) // Textbox-ul accepta doar numere
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // Textbox-ul accepta doar numere
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void shadowLabel23_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void ultrasoundsensor_Load(object sender, EventArgs e)
        {
        }

        private void skeetButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void skeetButton1_Click_2(object sender, EventArgs e)
        {
        }

        private void skeetButton2_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void shadowLabel19_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // Textbox-ul accepta doar numere
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void skeetButton3_Click(object sender, EventArgs e)
        {
        }

        private void skeetButton4_Click(object sender, EventArgs e)
        {
        }

        private void skeetButton5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleWaterPump.Checked = false;
            serialPort1.Write("L");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (labelPortState.Text == "OPEN" && butonDeschiderePort.Checked)
            {
                if (int.Parse(textBox4.Text) <= WaterTankCapacity && int.Parse(textBox4.Text) >= 50)
                {
                    sendData = "X" + textBox4.Text;
                    ToggleWaterPump.Checked = true;
                    serialPort1.Write(sendData);
                }
                else if(int.Parse(textBox4.Text) < 50)
                {
                    MessageBox.Show("Please enter of at least 50 ml !");
                    textBox4.Text = "";
                }
                else if(int.Parse(textBox4.Text) >= WaterTankCapacity)
                {
                    MessageBox.Show("The amount of water to irrigate the plants cannot be higher than the volume of the tank !");
                    textBox4.Text = "";
                }
            }
            else
                MessageBox.Show("Please open a port before enabling the irrigation system !");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialData = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {

                pozA = Convert.ToSByte(serialData.IndexOf("a"));
                pozB = Convert.ToSByte(serialData.IndexOf("b"));
                pozC = Convert.ToSByte(serialData.IndexOf("c"));
                pozD = Convert.ToSByte(serialData.IndexOf("d"));
                pozE = Convert.ToSByte(serialData.IndexOf("e"));
                pozF = Convert.ToSByte(serialData.IndexOf("f"));
                pozG = Convert.ToSByte(serialData.IndexOf("g"));
                pozH = Convert.ToSByte(serialData.IndexOf("h"));
                pozI = Convert.ToSByte(serialData.IndexOf("i")); // AICI

                senzorUltrasunet = serialData.Substring(pozB + 1, Math.Max(0,(pozC - pozB) - 1));
                AvailableWater = serialData.Substring(pozC + 1, Math.Max(0,(pozD - pozC) - 1));
                WaterOut = serialData.Substring(pozD + 1, Math.Max(0,(pozE - pozD) - 1));
                VolumeWaterLeft = serialData.Substring(pozE + 1, Math.Max(0,(pozF - pozE) - 1));
                pompaRunning = serialData.Substring(pozF + 1, (pozG - pozF) - 1);
                TankCapacity = serialData.Substring(pozG + 1, (pozH - pozG) - 1);
                WorkMode = serialData.Substring(pozH + 1, (pozI - pozH) - 1);//asdadsadasdasdsa

                WaterTankCapacity = double.Parse(TankCapacity);
                pompaIsRunning = int.Parse(pompaRunning);
                if (pompaIsRunning == 1)
                {
                    ToggleWaterPump.Enabled = true;
                    ToggleWaterPump.Checked = true;
                    ToggleWaterPump.Enabled = false;
                }
                else
                {
                    ToggleWaterPump.Enabled = true;
                    ToggleWaterPump.Checked = false;
                    ToggleWaterPump.Enabled = false;
                }

                shadowLabel12.Text = senzorUltrasunet;
                shadowLabel19.Text = AvailableWater;
                shadowLabel21.Text = VolumeWaterLeft;
                shadowLabel24.Text = TankCapacity;
                shadowLabel23.Text = WaterOut;

            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message);
            }
        }
    }
}
