namespace OOP.WinformApp
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
            buttonCar = new Button();
            button2 = new Button();
            carGroupBox = new GroupBox();
            resultsLabel = new Label();
            carRunButton = new Button();
            carResultTextBox = new TextBox();
            onOffCarButton = new Button();
            carLtsLabel = new Label();
            carGasButton = new Button();
            groupBox2 = new GroupBox();
            busRunButton = new Button();
            busResultsTextBox = new TextBox();
            onOffBusButton = new Button();
            busLtsLabel = new Label();
            BusDiselButton = new Button();
            carGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCar
            // 
            buttonCar.Location = new Point(51, 44);
            buttonCar.Name = "buttonCar";
            buttonCar.Size = new Size(134, 55);
            buttonCar.TabIndex = 0;
            buttonCar.Text = "Corneta de Auto";
            buttonCar.UseVisualStyleBackColor = true;
            buttonCar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 44);
            button2.Name = "button2";
            button2.Size = new Size(136, 55);
            button2.TabIndex = 1;
            button2.Text = "Corneta de Bus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // carGroupBox
            // 
            carGroupBox.Controls.Add(resultsLabel);
            carGroupBox.Controls.Add(carRunButton);
            carGroupBox.Controls.Add(carResultTextBox);
            carGroupBox.Controls.Add(onOffCarButton);
            carGroupBox.Controls.Add(carLtsLabel);
            carGroupBox.Controls.Add(carGasButton);
            carGroupBox.Controls.Add(buttonCar);
            carGroupBox.Location = new Point(70, 23);
            carGroupBox.Name = "carGroupBox";
            carGroupBox.Size = new Size(230, 448);
            carGroupBox.TabIndex = 2;
            carGroupBox.TabStop = false;
            carGroupBox.Text = "groupBox1";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(21, 296);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(67, 15);
            resultsLabel.TabIndex = 4;
            resultsLabel.Text = " Resultados";
            resultsLabel.Click += label1_Click;
            // 
            // carRunButton
            // 
            carRunButton.Location = new Point(142, 258);
            carRunButton.Name = "carRunButton";
            carRunButton.Size = new Size(75, 23);
            carRunButton.TabIndex = 9;
            carRunButton.Text = "Correr";
            carRunButton.UseVisualStyleBackColor = true;
            carRunButton.Click += carRunButton_Click;
            // 
            // carResultTextBox
            // 
            carResultTextBox.Location = new Point(14, 313);
            carResultTextBox.Multiline = true;
            carResultTextBox.Name = "carResultTextBox";
            carResultTextBox.Size = new Size(203, 129);
            carResultTextBox.TabIndex = 7;
            carResultTextBox.TextChanged += carResultTextBox_TextChanged;
            // 
            // onOffCarButton
            // 
            onOffCarButton.Location = new Point(21, 260);
            onOffCarButton.Name = "onOffCarButton";
            onOffCarButton.Size = new Size(75, 23);
            onOffCarButton.TabIndex = 5;
            onOffCarButton.Text = "button1";
            onOffCarButton.UseVisualStyleBackColor = true;
            onOffCarButton.Click += onOffCarButton_Click;
            // 
            // carLtsLabel
            // 
            carLtsLabel.AutoSize = true;
            carLtsLabel.Font = new Font("Segoe UI", 12F);
            carLtsLabel.Location = new Point(155, 178);
            carLtsLabel.Name = "carLtsLabel";
            carLtsLabel.Size = new Size(52, 21);
            carLtsLabel.TabIndex = 4;
            carLtsLabel.Text = "label1";
            // 
            // carGasButton
            // 
            carGasButton.BackgroundImageLayout = ImageLayout.Center;
            carGasButton.Image = Properties.Resources.gas_mini;
            carGasButton.Location = new Point(21, 129);
            carGasButton.Name = "carGasButton";
            carGasButton.Size = new Size(128, 123);
            carGasButton.TabIndex = 1;
            carGasButton.UseVisualStyleBackColor = true;
            carGasButton.Click += carGasButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(busRunButton);
            groupBox2.Controls.Add(busResultsTextBox);
            groupBox2.Controls.Add(onOffBusButton);
            groupBox2.Controls.Add(busLtsLabel);
            groupBox2.Controls.Add(BusDiselButton);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(339, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 448);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // busRunButton
            // 
            busRunButton.Location = new Point(139, 258);
            busRunButton.Name = "busRunButton";
            busRunButton.RightToLeft = RightToLeft.Yes;
            busRunButton.Size = new Size(75, 23);
            busRunButton.TabIndex = 9;
            busRunButton.Text = "Correr";
            busRunButton.UseVisualStyleBackColor = true;
            busRunButton.Click += busRunButton_Click;
            // 
            // busResultsTextBox
            // 
            busResultsTextBox.Location = new Point(11, 313);
            busResultsTextBox.Multiline = true;
            busResultsTextBox.Name = "busResultsTextBox";
            busResultsTextBox.Size = new Size(203, 129);
            busResultsTextBox.TabIndex = 8;
            busResultsTextBox.TextChanged += busResultsTextBox_TextChanged;
            // 
            // onOffBusButton
            // 
            onOffBusButton.Location = new Point(15, 260);
            onOffBusButton.Name = "onOffBusButton";
            onOffBusButton.Size = new Size(75, 23);
            onOffBusButton.TabIndex = 6;
            onOffBusButton.Text = "button1";
            onOffBusButton.UseVisualStyleBackColor = true;
            onOffBusButton.Click += onOffBusButton_Click;
            // 
            // busLtsLabel
            // 
            busLtsLabel.AutoSize = true;
            busLtsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            busLtsLabel.Location = new Point(144, 178);
            busLtsLabel.Name = "busLtsLabel";
            busLtsLabel.Size = new Size(52, 21);
            busLtsLabel.TabIndex = 3;
            busLtsLabel.Text = "label1";
            // 
            // BusDiselButton
            // 
            BusDiselButton.BackgroundImageLayout = ImageLayout.Center;
            BusDiselButton.Image = Properties.Resources.gas_mini;
            BusDiselButton.Location = new Point(15, 129);
            BusDiselButton.Name = "BusDiselButton";
            BusDiselButton.Size = new Size(128, 123);
            BusDiselButton.TabIndex = 2;
            BusDiselButton.UseVisualStyleBackColor = true;
            BusDiselButton.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 497);
            Controls.Add(groupBox2);
            Controls.Add(carGroupBox);
            MaximizeBox = false;
            MaximumSize = new Size(649, 551);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            carGroupBox.ResumeLayout(false);
            carGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCar;
        private Button button2;
        private GroupBox carGroupBox;
        private GroupBox groupBox2;
        private Button carGasButton;
        private Button BusDiselButton;
        private Label carLtsLabel;
        private Label busLtsLabel;
        private Button onOffCarButton;
        private Button onOffBusButton;
        private TextBox carResultTextBox;
        private TextBox busResultsTextBox;
        private Button carRunButton;
        private Button busRunButton;
        private Label resultsLabel;
    }
}
