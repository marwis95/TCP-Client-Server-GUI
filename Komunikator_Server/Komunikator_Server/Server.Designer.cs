namespace Komunikator_Server
{
    partial class frmServer
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
            this.txtOdbieranie = new System.Windows.Forms.RichTextBox();
            this.txtWysylanie = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSluchaj = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cmdWyslij = new System.Windows.Forms.Button();
            this.polaczenie = new System.ComponentModel.BackgroundWorker();
            this.odbieranie = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtOdbieranie
            // 
            this.txtOdbieranie.Location = new System.Drawing.Point(20, 17);
            this.txtOdbieranie.Name = "txtOdbieranie";
            this.txtOdbieranie.ReadOnly = true;
            this.txtOdbieranie.Size = new System.Drawing.Size(304, 155);
            this.txtOdbieranie.TabIndex = 0;
            this.txtOdbieranie.Text = "";
            // 
            // txtWysylanie
            // 
            this.txtWysylanie.Location = new System.Drawing.Point(20, 181);
            this.txtWysylanie.Name = "txtWysylanie";
            this.txtWysylanie.Size = new System.Drawing.Size(303, 72);
            this.txtWysylanie.TabIndex = 1;
            this.txtWysylanie.Text = "";
            this.txtWysylanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWysylanie_KeyPress);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 287);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(302, 47);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nr portu";
            // 
            // cmdSluchaj
            // 
            this.cmdSluchaj.Location = new System.Drawing.Point(344, 78);
            this.cmdSluchaj.Name = "cmdSluchaj";
            this.cmdSluchaj.Size = new System.Drawing.Size(82, 50);
            this.cmdSluchaj.TabIndex = 5;
            this.cmdSluchaj.Text = "Czekaj na połączenie";
            this.cmdSluchaj.UseVisualStyleBackColor = true;
            this.cmdSluchaj.Click += new System.EventHandler(this.cmdSluchaj_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(344, 33);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "8000";
            // 
            // cmdWyslij
            // 
            this.cmdWyslij.Enabled = false;
            this.cmdWyslij.Location = new System.Drawing.Point(344, 199);
            this.cmdWyslij.Name = "cmdWyslij";
            this.cmdWyslij.Size = new System.Drawing.Size(82, 36);
            this.cmdWyslij.TabIndex = 7;
            this.cmdWyslij.Text = "Wyślij";
            this.cmdWyslij.UseVisualStyleBackColor = true;
            this.cmdWyslij.Click += new System.EventHandler(this.cmdWyslij_Click);
            // 
            // polaczenie
            // 
            this.polaczenie.WorkerSupportsCancellation = true;
            this.polaczenie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.polaczenie_DoWork);
            // 
            // odbieranie
            // 
            this.odbieranie.WorkerSupportsCancellation = true;
            this.odbieranie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.odbieranie_DoWork);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(437, 351);
            this.Controls.Add(this.cmdWyslij);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.cmdSluchaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtWysylanie);
            this.Controls.Add(this.txtOdbieranie);
            this.MaximizeBox = false;
            this.Name = "frmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOdbieranie;
        private System.Windows.Forms.RichTextBox txtWysylanie;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSluchaj;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button cmdWyslij;
        private System.ComponentModel.BackgroundWorker polaczenie;
        private System.ComponentModel.BackgroundWorker odbieranie;
    }
}

