namespace WinPruebas
{
    partial class XtraForm1
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
            this.bttstart = new DevExpress.XtraEditors.SimpleButton();
            this.bttstop = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttstart
            // 
            this.bttstart.Location = new System.Drawing.Point(155, 34);
            this.bttstart.Name = "bttstart";
            this.bttstart.Size = new System.Drawing.Size(75, 23);
            this.bttstart.TabIndex = 0;
            this.bttstart.Text = "Iniciar";
            this.bttstart.Click += new System.EventHandler(this.bttstart_Click);
            // 
            // bttstop
            // 
            this.bttstop.Location = new System.Drawing.Point(435, 34);
            this.bttstop.Name = "bttstop";
            this.bttstop.Size = new System.Drawing.Size(75, 23);
            this.bttstop.TabIndex = 1;
            this.bttstop.Text = "Finalizar";
            this.bttstop.Click += new System.EventHandler(this.bttstop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(298, 151);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(350, 123);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(289, 150);
            this.memoEdit1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(321, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 408);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttstop);
            this.Controls.Add(this.bttstart);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bttstart;
        private DevExpress.XtraEditors.SimpleButton bttstop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}