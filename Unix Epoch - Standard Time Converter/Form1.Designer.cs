namespace Unix_Epoch___Standard_Time_Converter
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
            epochTextBox = new TextBox();
            groupBox1 = new GroupBox();
            standardTimePicker = new DateTimePicker();
            ConvertToStandardButton = new Button();
            ConvertToEpochButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // epochTextBox
            // 
            epochTextBox.Location = new Point(11, 33);
            epochTextBox.Name = "epochTextBox";
            epochTextBox.PlaceholderText = "Enter Unix Epoch Time";
            epochTextBox.Size = new Size(262, 23);
            epochTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(standardTimePicker);
            groupBox1.Controls.Add(ConvertToStandardButton);
            groupBox1.Controls.Add(ConvertToEpochButton);
            groupBox1.Controls.Add(epochTextBox);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 108);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Converter";
            // 
            // standardTimePicker
            // 
            standardTimePicker.Location = new Point(11, 62);
            standardTimePicker.Name = "standardTimePicker";
            standardTimePicker.Size = new Size(262, 23);
            standardTimePicker.TabIndex = 4;
            // 
            // ConvertToStandardButton
            // 
            ConvertToStandardButton.Location = new Point(279, 33);
            ConvertToStandardButton.Name = "ConvertToStandardButton";
            ConvertToStandardButton.Size = new Size(144, 23);
            ConvertToStandardButton.TabIndex = 3;
            ConvertToStandardButton.Text = "Convert to Standard";
            ConvertToStandardButton.UseVisualStyleBackColor = true;
            ConvertToStandardButton.Click += ConvertToStandardButton_Click_1;
            // 
            // ConvertToEpochButton
            // 
            ConvertToEpochButton.Location = new Point(279, 62);
            ConvertToEpochButton.Name = "ConvertToEpochButton";
            ConvertToEpochButton.Size = new Size(144, 23);
            ConvertToEpochButton.TabIndex = 3;
            ConvertToEpochButton.Text = "Convert to Epoch";
            ConvertToEpochButton.UseVisualStyleBackColor = true;
            ConvertToEpochButton.Click += ConvertToEpochButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 127);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Unix Epoch Time & Standard Time Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox epochTextBox;
        private GroupBox groupBox1;
        private Button ConvertToStandardButton;
        private Button ConvertToEpochButton;
        private DateTimePicker standardTimePicker;
    }
}