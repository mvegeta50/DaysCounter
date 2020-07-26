namespace DaysCounterUI
{
    partial class DayCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayCounter));
            this.lblDays = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlSetDate = new System.Windows.Forms.Panel();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSetStartingDate = new System.Windows.Forms.Label();
            this.btnSetStartingDate = new System.Windows.Forms.Button();
            this.pnlShowDaysInfo = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSetTekst = new System.Windows.Forms.Label();
            this.txtBoxSetLabel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblDateSince = new System.Windows.Forms.Label();
            this.pnlSetDate.SuspendLayout();
            this.pnlShowDaysInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(19, 81);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(48, 23);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pnlSetDate
            // 
            this.pnlSetDate.Controls.Add(this.txtBoxSetLabel);
            this.pnlSetDate.Controls.Add(this.lblSetTekst);
            this.pnlSetDate.Controls.Add(this.btnSetStartingDate);
            this.pnlSetDate.Controls.Add(this.lblSetStartingDate);
            this.pnlSetDate.Controls.Add(this.datePicker1);
            this.pnlSetDate.Location = new System.Drawing.Point(13, 13);
            this.pnlSetDate.Name = "pnlSetDate";
            this.pnlSetDate.Size = new System.Drawing.Size(370, 230);
            this.pnlSetDate.TabIndex = 1;
            // 
            // datePicker1
            // 
            this.datePicker1.Location = new System.Drawing.Point(7, 96);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(200, 20);
            this.datePicker1.TabIndex = 0;
            // 
            // lblSetStartingDate
            // 
            this.lblSetStartingDate.AutoSize = true;
            this.lblSetStartingDate.Location = new System.Drawing.Point(4, 72);
            this.lblSetStartingDate.Name = "lblSetStartingDate";
            this.lblSetStartingDate.Size = new System.Drawing.Size(84, 13);
            this.lblSetStartingDate.TabIndex = 1;
            this.lblSetStartingDate.Text = "Set starting date";
            // 
            // btnSetStartingDate
            // 
            this.btnSetStartingDate.Location = new System.Drawing.Point(7, 137);
            this.btnSetStartingDate.Name = "btnSetStartingDate";
            this.btnSetStartingDate.Size = new System.Drawing.Size(75, 23);
            this.btnSetStartingDate.TabIndex = 2;
            this.btnSetStartingDate.Text = "Set";
            this.btnSetStartingDate.UseVisualStyleBackColor = true;
            this.btnSetStartingDate.Click += new System.EventHandler(this.btnSetStartingDate_Click);
            // 
            // pnlShowDaysInfo
            // 
            this.pnlShowDaysInfo.Controls.Add(this.lblDateSince);
            this.pnlShowDaysInfo.Controls.Add(this.lblTitel);
            this.pnlShowDaysInfo.Controls.Add(this.btnReset);
            this.pnlShowDaysInfo.Controls.Add(this.lblDays);
            this.pnlShowDaysInfo.Location = new System.Drawing.Point(13, 13);
            this.pnlShowDaysInfo.Name = "pnlShowDaysInfo";
            this.pnlShowDaysInfo.Size = new System.Drawing.Size(367, 230);
            this.pnlShowDaysInfo.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSetTekst
            // 
            this.lblSetTekst.AutoSize = true;
            this.lblSetTekst.Location = new System.Drawing.Point(3, 16);
            this.lblSetTekst.Name = "lblSetTekst";
            this.lblSetTekst.Size = new System.Drawing.Size(74, 13);
            this.lblSetTekst.TabIndex = 3;
            this.lblSetTekst.Text = "Set label tekst";
            // 
            // txtBoxSetLabel
            // 
            this.txtBoxSetLabel.Location = new System.Drawing.Point(7, 41);
            this.txtBoxSetLabel.Name = "txtBoxSetLabel";
            this.txtBoxSetLabel.Size = new System.Drawing.Size(196, 20);
            this.txtBoxSetLabel.TabIndex = 4;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitel.Location = new System.Drawing.Point(5, 16);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(84, 40);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Days";
            // 
            // lblDateSince
            // 
            this.lblDateSince.AutoSize = true;
            this.lblDateSince.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSince.Location = new System.Drawing.Point(19, 111);
            this.lblDateSince.Name = "lblDateSince";
            this.lblDateSince.Size = new System.Drawing.Size(48, 23);
            this.lblDateSince.TabIndex = 3;
            this.lblDateSince.Text = "Days";
            // 
            // DayCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(380, 241);
            this.Controls.Add(this.pnlShowDaysInfo);
            this.Controls.Add(this.pnlSetDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DayCounter";
            this.Text = "Day counter";
            this.pnlSetDate.ResumeLayout(false);
            this.pnlSetDate.PerformLayout();
            this.pnlShowDaysInfo.ResumeLayout(false);
            this.pnlShowDaysInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlSetDate;
        private System.Windows.Forms.Button btnSetStartingDate;
        private System.Windows.Forms.Label lblSetStartingDate;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.Panel pnlShowDaysInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBoxSetLabel;
        private System.Windows.Forms.Label lblSetTekst;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblDateSince;
    }
}

