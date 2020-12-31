using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace thread_synchronization
{
    public partial class Form1 : Form
    {
        private Thread th1;
        private Thread th2;
        private Thread th3;
        private long counter = 1;
        private object monitorObject = new object();
        private Mutex mutexObject = new Mutex();
        private Semaphore semaphoreObject = new Semaphore(0,2);

        public Form1()
        {
            InitializeComponent();
        }

        // No Synchronization
        public void DegerArttir1()
        {
            for (int i = 1; i <= 100; ++i)
            {
                progressBar1.Value += 1;
                lbThreads.Items.Add("Thread 1");
                Thread.Sleep(10);
            }
        }
        public void DegerArttir2()
        {
            for (int j = 1; j <= 100; ++j)
            {
                progressBar2.Value += 1;
                lbThreads.Items.Add("Thread 2");
                Thread.Sleep(100);
            }
        }
        public void DegerArttir3()
        {
            for (int k = 1; k <= 100; ++k)
            {
                progressBar3.Value += 1;
                lbThreads.Items.Add("Thread 3");
                Thread.Sleep(150);
            }
        }

        // Interlocked
        public void DegerArttirInterlocked1()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar1.Value += 1;
                    lbThreads.Items.Add("Thread 1");
                    Thread.Sleep(80);
                }
            }
            catch { }
        }
        public void DegerArttirInterlocked2()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar2.Value += 1;
                    lbThreads.Items.Add("Thread 2");
                    Thread.Sleep(80);
                }
            }
            catch { }
        }
        public void DegerArttirInterlocked3()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar3.Value += 1;
                    lbThreads.Items.Add("Thread 3");
                    Thread.Sleep(80);
                }
            }
            catch { }
        }

        // Lock
        public void DegerArttirLock1()
        {
            for (int i = 1; i <= 100; ++i)
            {
                lock (this)
                {
                    progressBar1.Value += 1;
                    lbThreads.Items.Add("Thread 1");
                    Thread.Sleep(10);
                }
            }
        }
        public void DegerArttirLock2()
        {
            for (int j = 1; j <= 100; ++j)
            {
                lock (this)
                {
                    progressBar2.Value += 1;
                    lbThreads.Items.Add("Thread 2");
                    Thread.Sleep(100);
                }
            }
        }
        public void DegerArttirLock3()
        {
            for (int k = 1; k <= 100; ++k)
            {
                lock (this)
                {
                    progressBar3.Value += 1;
                    lbThreads.Items.Add("Thread 3");
                    Thread.Sleep(150);
                }
            }
        }

        // Monitor
        public void DegerArttirMonitor1()
        {
            for (int i = 1; i <= 100; ++i)
            {
                
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar1.Value += 1;
                    lbThreads.Items.Add("Thread 1");
                    Thread.Sleep(10);
                    Monitor.Pulse(monitorObject);
                }
                finally
                {
                    Monitor.Exit(monitorObject);
                }
            }
        }
        public void DegerArttirMonitor2()
        {
            for (int j = 1; j <= 100; ++j)
            {
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar2.Value += 1;
                    lbThreads.Items.Add("Thread 2");
                    Thread.Sleep(100);
                    Monitor.Pulse(monitorObject);
                }
                finally
                {
                    Monitor.Exit(monitorObject);
                }
            }
        }
        public void DegerArttirMonitor3()
        {
            for (int k = 1; k <= 100; ++k)
            {
                
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar3.Value += 1;
                    lbThreads.Items.Add("Thread 3");
                    Thread.Sleep(150);
                    Monitor.Pulse(monitorObject);
                }
                finally
                {
                    Monitor.Exit(monitorObject);
                }
            }
        }

        // Mutex
        public void DegerArttirMutex1()
        {
            for (int i = 1; i <= 100; ++i)
            {
                mutexObject.WaitOne();
                progressBar1.Value += 1;
                lbThreads.Items.Add("Thread 1");
                Thread.Sleep(10);
                mutexObject.ReleaseMutex();
            }
        }
        public void DegerArttirMutex2()
        {
            for (int j = 1; j <= 100; ++j)
            {
                mutexObject.WaitOne();
                progressBar2.Value += 1;
                lbThreads.Items.Add("Thread 2");
                Thread.Sleep(100);
                mutexObject.ReleaseMutex();
            }
        }
        public void DegerArttirMutex3()
        {
            for (int k = 1; k <= 100; ++k)
            {
                mutexObject.WaitOne();
                progressBar3.Value += 1;
                lbThreads.Items.Add("Thread 3");
                Thread.Sleep(150);
                mutexObject.ReleaseMutex();
            }
        }

        // Semaphore
        public void DegerArttirSemaphore1()
        {
            for (int i = 1; i <= 100; ++i)
            {
                semaphoreObject.WaitOne();
                progressBar1.Value += 1;
                lbThreads.Items.Add("Thread 1");
                Thread.Sleep(10);
                semaphoreObject.Release();
            }
        }
        public void DegerArttirSemaphore2()
        {
            for (int j = 1; j <= 100; ++j)
            {
                semaphoreObject.WaitOne();
                progressBar2.Value += 1;
                lbThreads.Items.Add("Thread 2");
                Thread.Sleep(100);
                semaphoreObject.Release();
            }
        }
        public void DegerArttirSemaphore3()
        {
            for (int k = 1; k <= 100; ++k)
            {
                semaphoreObject.WaitOne();
                progressBar3.Value += 1;
                lbThreads.Items.Add("Thread 3");
                Thread.Sleep(150);
                semaphoreObject.Release();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttir1));
            th2 = new Thread(new ThreadStart(DegerArttir2));
            th3 = new Thread(new ThreadStart(DegerArttir3));
            th1.Start();
            th2.Start();
            th3.Start();
        }

        private void btnInterlocked_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttirInterlocked1));
            th2 = new Thread(new ThreadStart(DegerArttirInterlocked2));
            th3 = new Thread(new ThreadStart(DegerArttirInterlocked3));
            th1.Start();
            th2.Start();
            th3.Start();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttirLock1));
            th2 = new Thread(new ThreadStart(DegerArttirLock2));
            th3 = new Thread(new ThreadStart(DegerArttirLock3));
            th1.Start();
            th2.Start();
            th3.Start();

        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttirMonitor1));
            th2 = new Thread(new ThreadStart(DegerArttirMonitor2));
            th3 = new Thread(new ThreadStart(DegerArttirMonitor3));
            th1.Start();
            th2.Start();
            th3.Start();
            
        }

        private void btnMutex_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttirMutex1));
            th2 = new Thread(new ThreadStart(DegerArttirMutex2));
            th3 = new Thread(new ThreadStart(DegerArttirMutex3));
            th1.Start();
            th2.Start();
            th3.Start();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            th1.Abort(); th2.Abort(); th3.Abort();
            progressBar1.Value = 0; progressBar2.Value = 0; progressBar3.Value = 0;
            progressBar1.Refresh(); progressBar2.Refresh(); progressBar3.Refresh();
            lbThreads.Items.Clear();
            counter = 1;
        }

        private void btnSemaphore_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArttirSemaphore1));
            th2 = new Thread(new ThreadStart(DegerArttirSemaphore2));
            th3 = new Thread(new ThreadStart(DegerArttirSemaphore3));
            th1.Start();
            th2.Start();
            th3.Start();
            semaphoreObject.Release(2);
        }
    }
}