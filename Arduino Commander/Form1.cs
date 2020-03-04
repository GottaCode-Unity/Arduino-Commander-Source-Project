using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoUploader;
using System.Threading;

namespace Arduino_Commander
{
    public partial class MainWindow : Form
    {
        string message = "";

        Button currentComponent;

        List<Component> componentsField = new List<Component>();

        public MainWindow()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void PortSetup(object sender, EventArgs e)
        {
            cbPort.Items.Clear();

            foreach (string port in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(port);
            }
        }

        private void SendMessage(string message)
        {
            Arduino.Write(message + '\n');
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbText.Text);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gbCommunication.Enabled)
            {
                MessageBox.Show("Please disconnect before closing...", "Arduino Commander", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;
            }
        }

        private void timerRecieve_Tick(object sender, EventArgs e)
        {
            if (gbCommunication.Enabled)
            {
                try
                {
                    if (Arduino.BytesToRead > 0)
                    {
                        char temp = (char)Arduino.ReadChar();

                        if (temp == '\n')
                        {
                            lbSerial.Items.Add(message);

                            message = "";
                        }
                        else
                        {
                            message += temp;
                        }
                    }
                }
                catch (Exception)
                {
                    gbCommunication.Enabled = false;

                    btnConnect.Text = "Connect";

                    btnRefrashPorts.Enabled = true;

                    cbPort.Enabled = true;

                    arduinoStatus.BackColor = Color.Red;

                    btnDisconnect.Enabled = false;

                    MessageBox.Show("The arduino got disconnected!", "Arduino Commander", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!gbCommunication.Enabled)
            {
                try
                {
                    Arduino.PortName = cbPort.Text;

                    Arduino.Open();

                    Arduino.Write("CHECKPROGRAM\n");

                    string awnser = "";

                    int i = 0;

                    Thread.Sleep(1000);

                    while (true)
                    {
                        if (Arduino.BytesToRead > 0)
                        {
                            char temp = (char)Arduino.ReadChar();

                            if (temp == '\n')
                            {
                                break;
                            }
                            else
                            {
                                awnser += temp;
                            }
                        }
                        else
                        {
                            i++;

                            if (i > 5000)
                            {
                                break;
                            }
                        }
                    }

                    if (awnser == "VERSIONCHECKED")
                    {

                        SendMessage("TEXT|:   Arduino  :||:  Commander :|");

                        btnConnect.Text = "Disconnect";

                        btnRefrashPorts.Enabled = false;

                        cbPort.Enabled = false;

                        gbCommunication.Enabled = true;

                        arduinoStatus.BackColor = Color.Green;

                        btnDisconnect.Enabled = true;
                    }
                    else
                    {
                        Arduino.Close();

                        MessageBox.Show("There is no arduino connected. If your arduino is connected it has to run the Arduino Commander Software! Please upload it.", "Arduino Commander", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        UploadProgram uu = new UploadProgram();

                        uu.Show();
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please select a port!", "Arduino Commander");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Arduino Commander");
                }
            }
            else
            {
                try
                {
                    SendMessage("TEXTReady to connect");

                    Arduino.Close();

                    btnConnect.Text = "Connect";

                    btnRefrashPorts.Enabled = true;

                    PortSetup(null, null);

                    gbCommunication.Enabled = false;

                    cbPort.Enabled = true;

                    arduinoStatus.BackColor = Color.Red;

                    btnDisconnect.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Arduino Commander");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbSerial.Items.Clear();
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void Disconnect(object sender, MouseEventArgs e)
        {
            try
            {
                SendMessage("TEXTReady to connect");

                Arduino.Close();

                btnConnect.Text = "Connect";

                btnRefrashPorts.Enabled = true;

                PortSetup(null, null);

                gbCommunication.Enabled = false;

                cbPort.Enabled = true;

                arduinoStatus.BackColor = Color.Red;

                btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Arduino Commander");
            }
        }

        private void UpdateInspector(Button sender)
        {
            List<Panel> panels = new List<Panel>();

            panels.Add(panelCreateComponent);

            foreach (Panel panel in panels)
            {
                panel.Enabled = false;

                panel.Visible = false;
            }

            Component currentComponent = null;

            foreach (Component component in componentsField)
            {
                if (component.myButton == sender)
                {
                    currentComponent = component;

                    break;
                }
            }

            try
            {
                switch (currentComponent.componentType)
                {
                    case Component.ComponentType.DigitalOUT:
                        break;
                    case Component.ComponentType.DigitalIN:
                        break;
                    case Component.ComponentType.AnalogOUT:
                        break;
                    case Component.ComponentType.AnalogIN:
                        break;
                    case Component.ComponentType.Calculate:
                        break;
                    case Component.ComponentType.IRremoteSensor:
                        break;
                }
            }
            catch (Exception)
            {
                //create component
            }
        }

        private void clesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect(null, null);

            Application.Exit();
        }

        private void component1_Click(object sender, EventArgs e)
        {
            UpdateInspector((Button)sender);
        }
    }

    public class Component
    {
        public ComponentType componentType;

        string name;

        public int pin;

        public Button myButton;

        int inValue;

        int outValue;

        public Component(string name, ComponentType componentType, int pin, Button parent)
        {
            this.name = name;

            this.componentType = componentType;

            this.pin = pin;

            myButton = parent;
        }

        public enum ComponentType
        {
            DigitalOUT,
            DigitalIN,
            AnalogOUT,
            AnalogIN,
            Calculate,
            IRremoteSensor,
        }

    }
}

