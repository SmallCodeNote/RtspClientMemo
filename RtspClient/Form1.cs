using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormStringCnvClass;

using OpenCvSharp;

namespace RtspClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

        }

        string thisExeDirPath;
        private VideoCapture capture;
        private Mat frame;

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }
        }

        private void setPictureBoxImage(PictureBox p, Bitmap img)
        {
            if (p.InvokeRequired)
            {
                p.Invoke((Action)(() =>
                {
                    setPictureBoxImage(p, img);
                }));
            }
            else
            {
                if (p.Image != null) p.Image.Dispose();
                p.Image = img;
            }
        }

        private void timer_ViewRefresh_Tick(object sender, EventArgs e)
        {
            timer_ViewRefresh.Stop();

            if (capture.Read(frame))
            {
                Task.Run(() =>
                {
                    setPictureBoxImage(pictureBox1, OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame));
                });
            }
            
            timer_ViewRefresh.Start();
        }

        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (tabControl_Main.SelectedTab.Name == "tabPage_View")
            {
                capture = new VideoCapture(textBox_RtspAddress.Text);
                frame = new Mat();
                
                timer_ViewRefresh.Start();
            }
            else
            {
                timer_ViewRefresh.Stop();
            }
        }
    }
}
