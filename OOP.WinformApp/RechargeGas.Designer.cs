namespace OOP.WinformApp
{
    partial class RechargeGas
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
            trackBar1 = new TrackBar();
            saveButton = new Button();
            ltsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(25, 34);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(356, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(162, 133);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // ltsLabel
            // 
            ltsLabel.AutoSize = true;
            ltsLabel.Location = new Point(183, 93);
            ltsLabel.Name = "ltsLabel";
            ltsLabel.Size = new Size(38, 15);
            ltsLabel.TabIndex = 2;
            ltsLabel.Text = "label1";
            ltsLabel.Click += label1_Click;
            // 
            // RechargeGas
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 168);
            Controls.Add(ltsLabel);
            Controls.Add(saveButton);
            Controls.Add(trackBar1);
            MaximizeBox = false;
            Name = "RechargeGas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recargar Combustible";
            Load += RechargeGas_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Button saveButton;
        private Label ltsLabel;
    }
}