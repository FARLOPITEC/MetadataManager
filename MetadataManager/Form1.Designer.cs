namespace MetadataManager
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
            button_Examine = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            textBox_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_created = new TextBox();
            textBox_accessed = new TextBox();
            textBox_modified = new TextBox();
            button1 = new Button();
            button_recharge = new Button();
            button_clear = new Button();
            SuspendLayout();
            // 
            // button_Examine
            // 
            button_Examine.Location = new Point(21, 31);
            button_Examine.Name = "button_Examine";
            button_Examine.Size = new Size(81, 23);
            button_Examine.TabIndex = 1;
            button_Examine.Text = "Examine...";
            button_Examine.UseVisualStyleBackColor = true;
            button_Examine.Click += button_Examine_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(403, 199);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(505, 35);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(170, 23);
            textBox_name.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 38);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 79);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Created";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 116);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Modified";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 151);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Accessed";
            // 
            // textBox_created
            // 
            textBox_created.Location = new Point(505, 76);
            textBox_created.Name = "textBox_created";
            textBox_created.Size = new Size(170, 23);
            textBox_created.TabIndex = 8;
            // 
            // textBox_accessed
            // 
            textBox_accessed.Location = new Point(505, 148);
            textBox_accessed.Name = "textBox_accessed";
            textBox_accessed.Size = new Size(170, 23);
            textBox_accessed.TabIndex = 9;
            // 
            // textBox_modified
            // 
            textBox_modified.Location = new Point(505, 113);
            textBox_modified.Name = "textBox_modified";
            textBox_modified.Size = new Size(170, 23);
            textBox_modified.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(444, 189);
            button1.Name = "button1";
            button1.Size = new Size(231, 48);
            button1.TabIndex = 11;
            button1.Text = "Modified Metadata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button_recharge
            // 
            button_recharge.Location = new Point(444, 243);
            button_recharge.Name = "button_recharge";
            button_recharge.Size = new Size(105, 23);
            button_recharge.TabIndex = 12;
            button_recharge.Text = "recharge";
            button_recharge.UseVisualStyleBackColor = true;
            button_recharge.Click += button_recharge_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(570, 243);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(105, 23);
            button_clear.TabIndex = 14;
            button_clear.Text = "clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 275);
            Controls.Add(button_clear);
            Controls.Add(button_recharge);
            Controls.Add(button1);
            Controls.Add(textBox_modified);
            Controls.Add(textBox_accessed);
            Controls.Add(textBox_created);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_name);
            Controls.Add(textBox1);
            Controls.Add(button_Examine);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Examine;
        private TextBox textBox1;
        private ListBox listBox1;
        private TextBox textBox_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_created;
        private TextBox textBox_accessed;
        private TextBox textBox_modified;
        private Button button1;
        private Button button_recharge;
        private Button button_clear;
    }
}
