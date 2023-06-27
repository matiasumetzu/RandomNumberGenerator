namespace RandomNumberGenerator
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
            numberLabel = new Label();
            generateButton = new Button();
            minValueTextBox = new TextBox();
            maxValueTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numberLabel.Location = new Point(103, 23);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(282, 59);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "Welcome :)";
            numberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            generateButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            generateButton.Location = new Point(152, 121);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(184, 68);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // minValueTextBox
            // 
            minValueTextBox.Location = new Point(115, 240);
            minValueTextBox.Name = "minValueTextBox";
            minValueTextBox.Size = new Size(69, 23);
            minValueTextBox.TabIndex = 2;
            
            // 
            // maxValueTextBox
            // 
            maxValueTextBox.Location = new Point(115, 274);
            maxValueTextBox.Name = "maxValueTextBox";
            maxValueTextBox.Size = new Size(69, 23);
            maxValueTextBox.TabIndex = 3;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 243);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Minimum Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 277);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 5;
            label2.Text = "Maximum Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 318);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maxValueTextBox);
            Controls.Add(minValueTextBox);
            Controls.Add(generateButton);
            Controls.Add(numberLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Random Number Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberLabel;
        private Button generateButton;
        private TextBox minValueTextBox;
        private TextBox maxValueTextBox;
        private Label label1;
        private Label label2;
    }
}