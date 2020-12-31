namespace thread_synchronization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInterlocked = new System.Windows.Forms.Button();
            this.lbThreads = new System.Windows.Forms.ListBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnMutex = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnSemaphore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(436, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 70);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(436, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(201, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Baþlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInterlocked
            // 
            this.btnInterlocked.Location = new System.Drawing.Point(201, 128);
            this.btnInterlocked.Name = "btnInterlocked";
            this.btnInterlocked.Size = new System.Drawing.Size(125, 23);
            this.btnInterlocked.TabIndex = 7;
            this.btnInterlocked.Text = "Interlocked";
            this.btnInterlocked.UseVisualStyleBackColor = true;
            this.btnInterlocked.Click += new System.EventHandler(this.btnInterlocked_Click);
            // 
            // lbThreads
            // 
            this.lbThreads.FormattingEnabled = true;
            this.lbThreads.Location = new System.Drawing.Point(12, 99);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(183, 173);
            this.lbThreads.TabIndex = 9;
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(202, 158);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(124, 23);
            this.btnLock.TabIndex = 10;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(202, 188);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(125, 23);
            this.btnMonitor.TabIndex = 11;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnMutex
            // 
            this.btnMutex.Location = new System.Drawing.Point(201, 218);
            this.btnMutex.Name = "btnMutex";
            this.btnMutex.Size = new System.Drawing.Size(125, 23);
            this.btnMutex.TabIndex = 12;
            this.btnMutex.Text = "Mutex";
            this.btnMutex.UseVisualStyleBackColor = true;
            this.btnMutex.Click += new System.EventHandler(this.btnMutex_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(373, 99);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 14;
            this.btnAbort.Text = "Sýfýrla";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnSemaphore
            // 
            this.btnSemaphore.Location = new System.Drawing.Point(202, 248);
            this.btnSemaphore.Name = "btnSemaphore";
            this.btnSemaphore.Size = new System.Drawing.Size(124, 23);
            this.btnSemaphore.TabIndex = 15;
            this.btnSemaphore.Text = "Semaphore";
            this.btnSemaphore.UseVisualStyleBackColor = true;
            this.btnSemaphore.Click += new System.EventHandler(this.btnSemaphore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.btnSemaphore);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnMutex);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.btnInterlocked);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInterlocked;
        private System.Windows.Forms.ListBox lbThreads;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnMutex;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnSemaphore;
    }
}

