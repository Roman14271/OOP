namespace CityPopulationApp
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
            listBoxCities = new ListBox();
            labelTotalCities = new Label();
            textBoxFilterName = new TextBox();
            label2 = new Label();
            numericUpDownFilterPopulation = new NumericUpDown();
            label3 = new Label();
            buttonAddCity = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterPopulation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBoxCities
            // 
            listBoxCities.FormattingEnabled = true;
            listBoxCities.Location = new Point(12, 12);
            listBoxCities.Name = "listBoxCities";
            listBoxCities.Size = new Size(343, 224);
            listBoxCities.TabIndex = 0;
            listBoxCities.SelectedIndexChanged += listBoxCities_SelectedIndexChanged;
            // 
            // labelTotalCities
            // 
            labelTotalCities.AutoSize = true;
            labelTotalCities.Location = new Point(245, 239);
            labelTotalCities.Name = "labelTotalCities";
            labelTotalCities.Size = new Size(110, 20);
            labelTotalCities.TabIndex = 1;
            labelTotalCities.Text = "Всього міст: 0\"";
            // 
            // textBoxFilterName
            // 
            textBoxFilterName.Location = new Point(361, 37);
            textBoxFilterName.Name = "textBoxFilterName";
            textBoxFilterName.Size = new Size(150, 27);
            textBoxFilterName.TabIndex = 2;
            textBoxFilterName.TextChanged += textBoxFilterName_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 12);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Фільтр за назвою";
            // 
            // numericUpDownFilterPopulation
            // 
            numericUpDownFilterPopulation.Location = new Point(361, 89);
            numericUpDownFilterPopulation.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownFilterPopulation.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownFilterPopulation.Name = "numericUpDownFilterPopulation";
            numericUpDownFilterPopulation.Size = new Size(150, 27);
            numericUpDownFilterPopulation.TabIndex = 4;
            numericUpDownFilterPopulation.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownFilterPopulation.ValueChanged += numericUpDownFilterPopulation_ValueChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 66);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 5;
            label3.Text = "Фільтр за населенням";
            // 
            // buttonAddCity
            // 
            buttonAddCity.Location = new Point(431, 288);
            buttonAddCity.Name = "buttonAddCity";
            buttonAddCity.Size = new Size(150, 30);
            buttonAddCity.TabIndex = 6;
            buttonAddCity.Text = "Додати місто";
            buttonAddCity.UseVisualStyleBackColor = true;
            buttonAddCity.Click += buttonAddCity_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(275, 290);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(buttonAddCity);
            Controls.Add(label3);
            Controls.Add(numericUpDownFilterPopulation);
            Controls.Add(label2);
            Controls.Add(textBoxFilterName);
            Controls.Add(labelTotalCities);
            Controls.Add(listBoxCities);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDownFilterPopulation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCities;
        private Label labelTotalCities;
        private TextBox textBoxFilterName;
        private Label label2;
        private NumericUpDown numericUpDownFilterPopulation;
        private Label label3;
        private Button buttonAddCity;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}
