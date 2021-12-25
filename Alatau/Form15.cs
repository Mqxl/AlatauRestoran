using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace Alatau
{
    public partial class Form15 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSourse;
        private ZXing.BarcodeReader reader;
        public Form15()
        {
            InitializeComponent();
        }
        delegate void SetStringDelegate(String parameter);
        void SetResult(string result)
        {
            if (!InvokeRequired)
                textBox1.Text = result;
            else
                Invoke(new SetStringDelegate(SetResult), new object[] { result });

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);


            reader = new ZXing.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>();
            reader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);


            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    listBox1.Items.Add(device.Name);
                }

                listBox1.SelectedIndex = 0;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSourse = new VideoCaptureDevice(videoDevices[listBox1.SelectedIndex].MonikerString);
            videoSourse.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSourse.Start();
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            pictureBox1.Image = bitmap;

            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
            if (result != null)
            {
                SetResult(result.Text);               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (videoSourse != null)
            {
                videoSourse.SignalToStop();
                videoSourse.WaitForStop();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string log = "155166";

            if (textBox1.Text == log)
            {
                MessageBox.Show("Добро пожаловать!!");
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");

            }
        }
    }
}
