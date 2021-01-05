using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, paths;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                files = opf.SafeFileNames;
                textBox1.Text = opf.FileName;
               
            }
            
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(textBox1.Text));
            }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Process.Start((System.IO.Directory.GetCurrentDirectory()) + "/../../../YoutubeDownloder/downloader/bin/Debug/downloader.exe");

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pause_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        
        private void lbl_stop_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        
    }
}
