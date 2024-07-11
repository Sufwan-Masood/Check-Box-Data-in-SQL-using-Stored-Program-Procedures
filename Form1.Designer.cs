namespace CheckBox_StoredProcedures_db
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
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(93, 31);
            label1.Name = "label1";
            label1.Size = new Size(183, 34);
            label1.TabIndex = 0;
            label1.Text = "Enter Name:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(282, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 36);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Football";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 33);
            textBox1.TabIndex = 2;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(282, 165);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(124, 36);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Hockey";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(282, 237);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(124, 36);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Tennis";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(227, 34);
            label2.TabIndex = 6;
            label2.Text = "Choose Hobies:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(282, 329);
            button1.Name = "button1";
            button1.Size = new Size(133, 53);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 442);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(715, 225);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}