namespace LabWork17
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
            fileDataGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            fileNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileDataGridView).BeginInit();
            SuspendLayout();
            // 
            // fileDataGridView1
            // 
            fileDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fileDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            fileDataGridView.BackgroundColor = SystemColors.ButtonFace;
            fileDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fileDataGridView.Location = new Point(14, 13);
            fileDataGridView.Name = "fileDataGridView1";
            fileDataGridView.Size = new Size(821, 409);
            fileDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 429);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 1;
            button1.Text = "Задание 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Task1Button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 429);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 2;
            button2.Text = "Задание 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Task2Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(217, 429);
            button3.Name = "button3";
            button3.Size = new Size(95, 39);
            button3.TabIndex = 3;
            button3.Text = "Задание 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Task3Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(318, 429);
            button4.Name = "button4";
            button4.Size = new Size(100, 39);
            button4.TabIndex = 4;
            button4.Text = "Задание 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Task4Button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(424, 429);
            button5.Name = "button5";
            button5.Size = new Size(86, 39);
            button5.TabIndex = 5;
            button5.Text = "Задание 5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(516, 429);
            button6.Name = "button6";
            button6.Size = new Size(94, 39);
            button6.TabIndex = 6;
            button6.Text = "Задание 6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(616, 429);
            button7.Name = "button7";
            button7.Size = new Size(101, 39);
            button7.TabIndex = 7;
            button7.Text = "Задание 7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(723, 429);
            button8.Name = "button8";
            button8.Size = new Size(112, 39);
            button8.TabIndex = 8;
            button8.Text = "Задание 8";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            fileNameTextBox.Location = new Point(318, 474);
            fileNameTextBox.Name = "textBox1";
            fileNameTextBox.Size = new Size(100, 23);
            fileNameTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 542);
            Controls.Add(fileNameTextBox);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(fileDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView fileDataGridView;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox fileNameTextBox;
    }
}
