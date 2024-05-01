namespace ПР13_в1
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            button1 = new Button();
            textBoxBirthDate = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 71);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(288, 71);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(182, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(232, 104);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(497, 71);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(182, 27);
            textBoxBirthDate.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxBirthDate);
            Controls.Add(button1);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button button1;
        private TextBox textBoxBirthDate;
    }
}
