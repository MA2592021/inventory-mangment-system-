namespace lastchance
{
    partial class dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.earndetlabel = new System.Windows.Forms.Label();
            this.earnmoney = new System.Windows.Forms.Label();
            this.earninglabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.soldlastlabel = new System.Windows.Forms.Label();
            this.soldnumber = new System.Windows.Forms.Label();
            this.soldlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progresslabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dashboard_label
            // 
            this.dashboard_label.AutoSize = true;
            this.dashboard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboard_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.dashboard_label.Location = new System.Drawing.Point(20, 17);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(169, 33);
            this.dashboard_label.TabIndex = 1;
            this.dashboard_label.Text = "DashBoard";
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchbox.Location = new System.Drawing.Point(419, 20);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(292, 34);
            this.searchbox.TabIndex = 2;
            this.searchbox.Text = "search for something";
            // 
            // searchbtn
            // 
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(720, 20);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(25, 34);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "x";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.earndetlabel);
            this.panel1.Controls.Add(this.earnmoney);
            this.panel1.Controls.Add(this.earninglabel);
            this.panel1.Location = new System.Drawing.Point(20, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 130);
            this.panel1.TabIndex = 4;
            // 
            // earndetlabel
            // 
            this.earndetlabel.AutoSize = true;
            this.earndetlabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earndetlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.earndetlabel.Location = new System.Drawing.Point(21, 99);
            this.earndetlabel.Name = "earndetlabel";
            this.earndetlabel.Size = new System.Drawing.Size(137, 17);
            this.earndetlabel.TabIndex = 2;
            this.earndetlabel.Text = "Details of last 28 Days";
            // 
            // earnmoney
            // 
            this.earnmoney.AutoSize = true;
            this.earnmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.earnmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.earnmoney.Location = new System.Drawing.Point(23, 55);
            this.earnmoney.Name = "earnmoney";
            this.earnmoney.Size = new System.Drawing.Size(83, 33);
            this.earnmoney.TabIndex = 1;
            this.earnmoney.Text = "1234";
            // 
            // earninglabel
            // 
            this.earninglabel.AutoSize = true;
            this.earninglabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earninglabel.ForeColor = System.Drawing.Color.White;
            this.earninglabel.Location = new System.Drawing.Point(21, 16);
            this.earninglabel.Name = "earninglabel";
            this.earninglabel.Size = new System.Drawing.Size(85, 25);
            this.earninglabel.TabIndex = 0;
            this.earninglabel.Text = "Earnings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.soldlastlabel);
            this.panel2.Controls.Add(this.soldnumber);
            this.panel2.Controls.Add(this.soldlabel);
            this.panel2.Location = new System.Drawing.Point(307, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 130);
            this.panel2.TabIndex = 5;
            // 
            // soldlastlabel
            // 
            this.soldlastlabel.AutoSize = true;
            this.soldlastlabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldlastlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.soldlastlabel.Location = new System.Drawing.Point(21, 99);
            this.soldlastlabel.Name = "soldlastlabel";
            this.soldlastlabel.Size = new System.Drawing.Size(137, 17);
            this.soldlastlabel.TabIndex = 2;
            this.soldlastlabel.Text = "Details of last 28 Days";
            // 
            // soldnumber
            // 
            this.soldnumber.AutoSize = true;
            this.soldnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soldnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.soldnumber.Location = new System.Drawing.Point(23, 55);
            this.soldnumber.Name = "soldnumber";
            this.soldnumber.Size = new System.Drawing.Size(83, 33);
            this.soldnumber.TabIndex = 1;
            this.soldnumber.Text = "1234";
            // 
            // soldlabel
            // 
            this.soldlabel.AutoSize = true;
            this.soldlabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soldlabel.ForeColor = System.Drawing.Color.White;
            this.soldlabel.Location = new System.Drawing.Point(21, 16);
            this.soldlabel.Name = "soldlabel";
            this.soldlabel.Size = new System.Drawing.Size(49, 25);
            this.soldlabel.TabIndex = 0;
            this.soldlabel.Text = "Sold";
            this.soldlabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.progresslabel);
            this.panel3.Location = new System.Drawing.Point(20, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 118);
            this.panel3.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 52;
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progresslabel.ForeColor = System.Drawing.Color.White;
            this.progresslabel.Location = new System.Drawing.Point(21, 16);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(85, 25);
            this.progresslabel.TabIndex = 0;
            this.progresslabel.Text = "Progress";
            this.progresslabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(757, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.dashboard_label);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label dashboard_label;
        private TextBox searchbox;
        private Button searchbtn;
        private Panel panel1;
        private Label earndetlabel;
        private Label earnmoney;
        private Label earninglabel;
        private Panel panel2;
        private Label soldlastlabel;
        private Label soldnumber;
        private Label soldlabel;
        private Panel panel3;
        private Label progresslabel;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}