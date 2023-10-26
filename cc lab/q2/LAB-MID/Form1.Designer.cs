namespace LAB_MID
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
            InputTextBox = new RichTextBox();
            button1 = new Button();
            OutputLabel = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(180, 86);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(224, 78);
            InputTextBox.TabIndex = 0;
            InputTextBox.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(403, 208);
            button1.Name = "button1";
            button1.Size = new Size(103, 49);
            button1.TabIndex = 1;
            button1.Text = "Parse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.Location = new Point(519, 86);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(222, 78);
            OutputLabel.TabIndex = 2;
            OutputLabel.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 39);
            label1.TabIndex = 3;
            label1.Text = "INPUT BOX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(539, 40);
            label2.Name = "label2";
            label2.Size = new Size(189, 39);
            label2.TabIndex = 4;
            label2.Text = "OUTPUT BOX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputLabel);
            Controls.Add(button1);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox InputTextBox;
        private Button button1;
        private RichTextBox OutputLabel;
        private Label label1;
        private Label label2;
    }
}