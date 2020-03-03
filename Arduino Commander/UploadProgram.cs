using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoUploader;
using System.IO.Ports;

namespace Arduino_Commander
{
    public partial class UploadProgram : Form
    {
        public UploadProgram()
        {
            InitializeComponent();

            cbPort.Items.Clear();

            foreach (string port in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(port);
            }

            cbModel.Items.Add("Leonardo");

            cbModel.Items.Add("Mega1284");

            cbModel.Items.Add("Mega2560");

            cbModel.Items.Add("Micro");

            cbModel.Items.Add("NanoR2");

            cbModel.Items.Add("NanoR3");

            cbModel.Items.Add("UnoR3");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoSketchUploaderOptions options = new ArduinoSketchUploaderOptions();

                options.PortName = cbPort.Text;

                options.ArduinoModel = (ArduinoUploader.Hardware.ArduinoModel)cbModel.SelectedIndex;

                options.FileName = Application.StartupPath + "\\code.hex";

                ArduinoSketchUploader ard = new ArduinoSketchUploader(options);

                DialogResult res = MessageBox.Show("This will delete the previous program of the arduino! Are you sure?", "Arduino Commander", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                {
                    ard.UploadSketch();

                    MessageBox.Show("Success!", "Arduino Commander", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
