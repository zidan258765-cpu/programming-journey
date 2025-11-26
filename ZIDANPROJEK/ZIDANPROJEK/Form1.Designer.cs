namespace ZIDANPROJEK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbharga = new ComboBox();
            Harga = new Label();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            label7 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            nm = new DataGridViewTextBoxColumn();
            nt = new DataGridViewTextBoxColumn();
            tgl = new DataGridViewTextBoxColumn();
            jm = new DataGridViewTextBoxColumn();
            tj = new DataGridViewTextBoxColumn();
            jml = new DataGridViewTextBoxColumn();
            ttl = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            tn = new DataGridViewTextBoxColumn();
            hgr = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 0;
            label1.Text = "PO KATAJAYA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbharga);
            groupBox1.Controls.Add(Harga);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(827, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENU";
            // 
            // cbharga
            // 
            cbharga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbharga.FormattingEnabled = true;
            cbharga.Items.AddRange(new object[] { "150000", "250000", "200000", "300000" });
            cbharga.Location = new Point(631, 140);
            cbharga.Name = "cbharga";
            cbharga.Size = new Size(182, 28);
            cbharga.TabIndex = 14;
            cbharga.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            // 
            // Harga
            // 
            Harga.AutoSize = true;
            Harga.Location = new Point(564, 143);
            Harga.Name = "Harga";
            Harga.Size = new Size(50, 20);
            Harga.TabIndex = 13;
            Harga.Text = "Harga";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox6.Location = new Point(103, 111);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(43, 28);
            comboBox6.TabIndex = 12;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox5.Location = new Point(631, 82);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(97, 28);
            comboBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(564, 90);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 10;
            label7.Text = "Jumlah";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Semarang", "Malang", "Tegal", "Bandung", "Jakarta" });
            comboBox4.Location = new Point(631, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 28);
            comboBox4.TabIndex = 9;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "08.00", "09.30", "13.00", "15.30", "19.00" });
            comboBox3.Location = new Point(103, 152);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(97, 28);
            comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026" });
            comboBox2.Location = new Point(304, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(97, 28);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            comboBox1.Location = new Point(152, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 38);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 4;
            label6.Text = "Tujuan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 3;
            label5.Text = "Jam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Tanggal";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "No Telepon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Nama";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(944, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMASI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 40);
            label8.Name = "label8";
            label8.Size = new Size(248, 20);
            label8.TabIndex = 0;
            label8.Text = "SELAMAT MENIKMATI PERJALANAN";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nm, nt, tgl, jm, tj, jml, ttl });
            dataGridView1.Location = new Point(18, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(964, 162);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nm
            // 
            nm.HeaderText = "Nama";
            nm.MinimumWidth = 6;
            nm.Name = "nm";
            nm.ReadOnly = true;
            nm.Width = 125;
            // 
            // nt
            // 
            nt.HeaderText = "No Telpon";
            nt.MinimumWidth = 6;
            nt.Name = "nt";
            nt.ReadOnly = true;
            nt.Width = 125;
            // 
            // tgl
            // 
            tgl.HeaderText = "Tanggal";
            tgl.MinimumWidth = 6;
            tgl.Name = "tgl";
            tgl.ReadOnly = true;
            tgl.Width = 125;
            // 
            // jm
            // 
            jm.HeaderText = "Jam";
            jm.MinimumWidth = 6;
            jm.Name = "jm";
            jm.ReadOnly = true;
            jm.Width = 125;
            // 
            // tj
            // 
            tj.HeaderText = "Tujuan";
            tj.MinimumWidth = 6;
            tj.Name = "tj";
            tj.ReadOnly = true;
            tj.Width = 125;
            // 
            // jml
            // 
            jml.HeaderText = "Jumlah";
            jml.MinimumWidth = 6;
            jml.Name = "jml";
            jml.ReadOnly = true;
            jml.Width = 125;
            // 
            // ttl
            // 
            ttl.HeaderText = "Total";
            ttl.MinimumWidth = 6;
            ttl.Name = "ttl";
            ttl.ReadOnly = true;
            ttl.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(933, 208);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 4;
            button1.Text = "PESAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(1101, 208);
            button2.Name = "button2";
            button2.Size = new Size(148, 41);
            button2.TabIndex = 5;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(43, 280);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1005, 203);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "DETAIL PEMESANAN";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { tn, hgr });
            dataGridView2.Location = new Point(1054, 280);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(262, 203);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // tn
            // 
            tn.HeaderText = "Tujuan";
            tn.MinimumWidth = 6;
            tn.Name = "tn";
            tn.ReadOnly = true;
            tn.Width = 125;
            // 
            // hgr
            // 
            hgr.HeaderText = "Harga";
            hgr.MinimumWidth = 6;
            hgr.Name = "hgr";
            hgr.ReadOnly = true;
            hgr.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 495);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tiket Bus";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private ComboBox comboBox5;
        private Label label7;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private GroupBox groupBox2;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
        private ComboBox comboBox6;
        private ComboBox comboBox2;
        private Label Harga;
        private ComboBox cbharga;
        private DataGridViewTextBoxColumn nm;
        private DataGridViewTextBoxColumn nt;
        private DataGridViewTextBoxColumn tgl;
        private DataGridViewTextBoxColumn jm;
        private DataGridViewTextBoxColumn tj;
        private DataGridViewTextBoxColumn jml;
        private DataGridViewTextBoxColumn ttl;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn tn;
        private DataGridViewTextBoxColumn hgr;
    }
}
