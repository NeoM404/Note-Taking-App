namespace Notes
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
            title_label = new Label();
            title_textBox = new TextBox();
            dataGridView1 = new DataGridView();
            notes_label = new Label();
            notes_textBox = new TextBox();
            new_button = new Button();
            save_button = new Button();
            read_button = new Button();
            dlt_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Sitka Heading", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            title_label.Location = new Point(38, 19);
            title_label.Name = "title_label";
            title_label.Size = new Size(63, 35);
            title_label.TabIndex = 0;
            title_label.Text = "Title";
            // 
            // title_textBox
            // 
            title_textBox.Location = new Point(113, 24);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(395, 31);
            title_textBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(610, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(472, 412);
            dataGridView1.TabIndex = 2;
            // 
            // notes_label
            // 
            notes_label.AutoSize = true;
            notes_label.Font = new Font("Sitka Heading", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            notes_label.Location = new Point(26, 80);
            notes_label.Name = "notes_label";
            notes_label.Size = new Size(75, 35);
            notes_label.TabIndex = 3;
            notes_label.Text = "Notes";
            // 
            // notes_textBox
            // 
            notes_textBox.Location = new Point(113, 85);
            notes_textBox.Multiline = true;
            notes_textBox.Name = "notes_textBox";
            notes_textBox.Size = new Size(389, 273);
            notes_textBox.TabIndex = 4;
            // 
            // new_button
            // 
            new_button.BackColor = SystemColors.GradientActiveCaption;
            new_button.Location = new Point(107, 388);
            new_button.Name = "new_button";
            new_button.Size = new Size(59, 34);
            new_button.TabIndex = 5;
            new_button.Text = "New";
            new_button.UseVisualStyleBackColor = false;
            new_button.Click += new_button_Click;
            // 
            // save_button
            // 
            save_button.BackColor = SystemColors.GradientActiveCaption;
            save_button.Location = new Point(203, 388);
            save_button.Name = "save_button";
            save_button.Size = new Size(71, 34);
            save_button.TabIndex = 6;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // read_button
            // 
            read_button.BackColor = SystemColors.GradientActiveCaption;
            read_button.Location = new Point(311, 388);
            read_button.Name = "read_button";
            read_button.Size = new Size(77, 34);
            read_button.TabIndex = 7;
            read_button.Text = "Read";
            read_button.UseVisualStyleBackColor = false;
            read_button.Click += read_button_Click;
            // 
            // dlt_button
            // 
            dlt_button.BackColor = SystemColors.GradientActiveCaption;
            dlt_button.Location = new Point(419, 388);
            dlt_button.Name = "dlt_button";
            dlt_button.Size = new Size(83, 34);
            dlt_button.TabIndex = 8;
            dlt_button.Text = "Delete";
            dlt_button.UseVisualStyleBackColor = false;
            dlt_button.Click += dlt_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1094, 450);
            Controls.Add(dlt_button);
            Controls.Add(read_button);
            Controls.Add(save_button);
            Controls.Add(new_button);
            Controls.Add(notes_textBox);
            Controls.Add(notes_label);
            Controls.Add(dataGridView1);
            Controls.Add(title_textBox);
            Controls.Add(title_label);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_label;
        private TextBox title_textBox;
        private DataGridView dataGridView1;
        private Label notes_label;
        private TextBox notes_textBox;
        private Button new_button;
        private Button save_button;
        private Button read_button;
        private Button dlt_button;
    }
}