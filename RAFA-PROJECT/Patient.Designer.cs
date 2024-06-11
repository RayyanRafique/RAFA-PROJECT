namespace RAFA_PROJECT
{
    partial class Patient
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeToTakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialInstructionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(76, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Patient\'s Medication";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(155)))), ((int)(((byte)(198)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(10, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 86);
            this.panel3.TabIndex = 20;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(RAFA_PROJECT.Medicine);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage5.Size = new System.Drawing.Size(386, 654);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Book an appointment";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage4.Size = new System.Drawing.Size(386, 654);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Refill Reminders";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(386, 654);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Medication Reminder";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage3.Size = new System.Drawing.Size(386, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Medication Log";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.intakeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.specialInstructionsDataGridViewTextBoxColumn,
            this.timeToTakeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(384, 652);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // timeToTakeDataGridViewTextBoxColumn
            // 
            this.timeToTakeDataGridViewTextBoxColumn.DataPropertyName = "TimeToTake";
            this.timeToTakeDataGridViewTextBoxColumn.HeaderText = "TimeToTake";
            this.timeToTakeDataGridViewTextBoxColumn.Name = "timeToTakeDataGridViewTextBoxColumn";
            this.timeToTakeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialInstructionsDataGridViewTextBoxColumn
            // 
            this.specialInstructionsDataGridViewTextBoxColumn.DataPropertyName = "SpecialInstructions";
            this.specialInstructionsDataGridViewTextBoxColumn.HeaderText = "SpecialInstructions";
            this.specialInstructionsDataGridViewTextBoxColumn.Name = "specialInstructionsDataGridViewTextBoxColumn";
            this.specialInstructionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intakeDataGridViewTextBoxColumn
            // 
            this.intakeDataGridViewTextBoxColumn.DataPropertyName = "Intake";
            this.intakeDataGridViewTextBoxColumn.HeaderText = "Intake";
            this.intakeDataGridViewTextBoxColumn.Name = "intakeDataGridViewTextBoxColumn";
            this.intakeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            this.dosageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(386, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medication entry";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 616);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frequency / Intake:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(10, 188);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 35);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Location = new System.Drawing.Point(10, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 35);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Special Instructions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dosage (mg):";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(10, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Location = new System.Drawing.Point(10, 269);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(337, 35);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicine Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox5.Location = new System.Drawing.Point(10, 351);
            this.textBox5.Margin = new System.Windows.Forms.Padding(1);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 35);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(155)))), ((int)(((byte)(198)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(37, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(155)))), ((int)(((byte)(198)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(190, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time to take\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-ddTHH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 435);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 36);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(10, 112);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 684);
            this.tabControl1.TabIndex = 19;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(418, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialInstructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToTakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}