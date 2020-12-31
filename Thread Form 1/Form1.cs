using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yordam1()
        {
            for (int i = 1; i <= 100; i++) {
                Thread.Sleep(25);
                progressBar1.Value = i;
                listBox1.Items.Add("Say1 : " + i);
            }
        }

        void Yordam2()
        {
            for (int i = 1; i <= 100; i++) {
                Thread.Sleep(50);
                progressBar2.Value = i;
                listBox1.Items.Add("Say2 : " + i);
            }
        }

        void Yordam3()
        {
            for (int i = 1; i <= 100; i++) {
                Thread.Sleep(100);
                progressBar3.Value = i;
                listBox1.Items.Add("Say3 : " + i);
            }
        }

        Thread thr1, thr2, thr3;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thr1 = new Thread(new ThreadStart(Yordam1));
            thr1.Start();
            thr2 = new Thread(new ThreadStart(Yordam2));
            thr2.Start();
            thr3 = new Thread(new ThreadStart(Yordam3));
            thr3.Start();
            //listBox1.SelectedIndex = listBox1.Items.Count-1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thr1.Abort();
            thr2.Abort();
            thr3.Abort();
        }
    }
}