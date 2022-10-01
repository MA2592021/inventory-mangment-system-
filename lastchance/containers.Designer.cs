namespace lastchance
{
    partial class containers
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.clients_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nopro = new System.Windows.Forms.Label();
            this.productslabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(712, 12);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(25, 34);
            this.searchbtn.TabIndex = 14;
            this.searchbtn.Text = "x";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchbox.Location = new System.Drawing.Point(411, 12);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(292, 34);
            this.searchbox.TabIndex = 13;
            this.searchbox.Text = "search for something";
            this.searchbox.Click += new System.EventHandler(this.searchbox_Click);
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // clients_label
            // 
            this.clients_label.AutoSize = true;
            this.clients_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clients_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.clients_label.Location = new System.Drawing.Point(12, 9);
            this.clients_label.Name = "clients_label";
            this.clients_label.Size = new System.Drawing.Size(166, 33);
            this.clients_label.TabIndex = 12;
            this.clients_label.Text = "Containers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.nopro);
            this.panel1.Controls.Add(this.productslabel);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 457);
            this.panel1.TabIndex = 15;
            // 
            // btnnew
            // 
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnnew.Location = new System.Drawing.Point(539, 401);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(186, 42);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "Add";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnedit.Location = new System.Drawing.Point(265, 401);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(186, 42);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndelete.Location = new System.Drawing.Point(3, 401);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(186, 42);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Location = new System.Drawing.Point(48, 29);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(54, 15);
            this.test.TabIndex = 5;
            this.test.Text = "test label";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(722, 331);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // nopro
            // 
            this.nopro.AutoSize = true;
            this.nopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nopro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.nopro.Location = new System.Drawing.Point(451, 14);
            this.nopro.Name = "nopro";
            this.nopro.Size = new System.Drawing.Size(83, 33);
            this.nopro.TabIndex = 3;
            this.nopro.Text = "1234";
            // 
            // productslabel
            // 
            this.productslabel.AutoSize = true;
            this.productslabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productslabel.ForeColor = System.Drawing.Color.White;
            this.productslabel.Location = new System.Drawing.Point(265, 21);
            this.productslabel.Name = "productslabel";
            this.productslabel.Size = new System.Drawing.Size(132, 25);
            this.productslabel.TabIndex = 2;
            this.productslabel.Text = "NO. products  ";
            // 
            // containers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(757, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.clients_label);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "containers";
            this.Text = "containers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button searchbtn;
        private TextBox searchbox;
        private Label clients_label;
        private Panel panel1;
        private Button btnnew;
        private Button btnedit;
        private Button btndelete;
        private Label test;
        private DataGridView dataGridView1;
        private Label nopro;
        private Label productslabel;
    }
}