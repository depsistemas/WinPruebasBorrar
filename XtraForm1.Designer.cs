﻿namespace WinPruebas
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
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.spenumero = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spenumero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bttstart
            // 
            this.bttstart.ImageOptions.SvgImage = global::WinPruebas.Properties.Resources.gettingstarted;
            this.bttstart.Location = new System.Drawing.Point(33, -5);
            this.bttstart.Name = "bttstart";
            this.bttstart.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.bttstart.Size = new System.Drawing.Size(85, 59);
            this.bttstart.TabIndex = 0;
            this.bttstart.Text = "Iniciar";
            this.bttstart.Click += new System.EventHandler(this.bttstart_Click);
            // 
            // bttstop
            // 
            this.bttstop.ImageOptions.SvgImage = global::WinPruebas.Properties.Resources.stop;
            this.bttstop.Location = new System.Drawing.Point(171, 1);
            this.bttstop.Name = "bttstop";
            this.bttstop.Size = new System.Drawing.Size(94, 47);
            this.bttstop.TabIndex = 1;
            this.bttstop.Text = "Finalizar";
            this.bttstop.Click += new System.EventHandler(this.bttstop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(12, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 319);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(341, 76);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Size = new System.Drawing.Size(364, 320);
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
            this.simpleButton1.ImageOptions.Image = global::WinPruebas.Properties.Resources.add_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(548, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 43);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(12, 55);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(693, 18);
            this.marqueeProgressBarControl1.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(614, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Boton 2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(614, 29);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Boton 3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // spenumero
            // 
            this.spenumero.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spenumero.Location = new System.Drawing.Point(391, 8);
            this.spenumero.Name = "spenumero";
            this.spenumero.Properties.Appearance.BackColor = System.Drawing.Color.Red;
            this.spenumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.spenumero.Properties.Appearance.Options.UseBackColor = true;
            this.spenumero.Properties.Appearance.Options.UseFont = true;
            this.spenumero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spenumero.Size = new System.Drawing.Size(125, 40);
            this.spenumero.TabIndex = 8;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 408);
            this.Controls.Add(this.spenumero);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttstop);
            this.Controls.Add(this.bttstart);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spenumero.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bttstart;
        private DevExpress.XtraEditors.SimpleButton bttstop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SpinEdit spenumero;
    }
}