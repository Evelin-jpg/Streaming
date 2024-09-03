using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using NAudio.Wave;


namespace Streaming
{
    public partial class Form4 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputFilePath = "output.wav";



        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;


        public Form4()
        {
            InitializeComponent();
            btn_Save.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargaDispositivos();
        }

        public void CargaDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                comboBox1.Text = MisDispositivos[0].ToString();

            }
            else
            {
                HayDispositivos = false;
            }
        }

        public void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;

            }

        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            waveIn = new WaveInEvent();
            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveIn.WaveFormat = new WaveFormat(44100, 1);

            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);

            waveIn.StartRecording();
            btn_start.Enabled = false;
            btn_Save.Enabled = true;

            lbl_grab.Text = "Recording....";
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn = null;

            writer.Close();
            writer.Dispose();
            writer = null;

            btn_start.Enabled = true;
            btn_Save.Enabled = false;

            MessageBox.Show("Grabación guardada en " + outputFilePath);

            lbl_sav.Text = "Audio Save....";
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}