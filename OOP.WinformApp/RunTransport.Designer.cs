namespace OOP.WinformApp
{
    partial class RunTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            distanceTextBox = new TextBox();
            label1 = new Label();
            startButton = new Button();
            SuspendLayout();
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(155, 37);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(124, 23);
            distanceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 1;
            label1.Text = "Distancia (Km)";
            // 
            // startButton
            // 
            startButton.Location = new Point(90, 77);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 42);
            startButton.TabIndex = 2;
            startButton.Text = "Iniciar";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // RunTransport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 152);
            Controls.Add(startButton);
            Controls.Add(label1);
            Controls.Add(distanceTextBox);
            Name = "RunTransport";
            Text = "RunTransport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox distanceTextBox;
        private Label label1;
        private Button startButton;
    }
}