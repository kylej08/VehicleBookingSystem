
namespace VehicleBookingUI
{
    partial class AddVehicleForm
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
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.modelErrorLabel = new System.Windows.Forms.Label();
            this.makeErrorLabel = new System.Windows.Forms.Label();
            this.registrationNumberErrorLabel = new System.Windows.Forms.Label();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelTextBox.Location = new System.Drawing.Point(154, 17);
            this.modelTextBox.MaxLength = 50;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(155, 22);
            this.modelTextBox.TabIndex = 0;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeTextBox.Location = new System.Drawing.Point(154, 60);
            this.makeTextBox.MaxLength = 50;
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(155, 22);
            this.makeTextBox.TabIndex = 1;
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberTextBox.Location = new System.Drawing.Point(154, 106);
            this.registrationNumberTextBox.MaxLength = 50;
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(155, 22);
            this.registrationNumberTextBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelLabel.Location = new System.Drawing.Point(29, 20);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(43, 14);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeLabel.Location = new System.Drawing.Point(29, 63);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(38, 14);
            this.makeLabel.TabIndex = 5;
            this.makeLabel.Text = "Make";
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberLabel.Location = new System.Drawing.Point(29, 109);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(120, 14);
            this.registrationNumberLabel.TabIndex = 6;
            this.registrationNumberLabel.Text = "Registration Number";
            // 
            // modelErrorLabel
            // 
            this.modelErrorLabel.AutoSize = true;
            this.modelErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.modelErrorLabel.Location = new System.Drawing.Point(151, 40);
            this.modelErrorLabel.Name = "modelErrorLabel";
            this.modelErrorLabel.Size = new System.Drawing.Size(180, 14);
            this.modelErrorLabel.TabIndex = 7;
            this.modelErrorLabel.Text = "Please enter a valid model name";
            this.modelErrorLabel.Visible = false;
            // 
            // makeErrorLabel
            // 
            this.makeErrorLabel.AutoSize = true;
            this.makeErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.makeErrorLabel.Location = new System.Drawing.Point(151, 83);
            this.makeErrorLabel.Name = "makeErrorLabel";
            this.makeErrorLabel.Size = new System.Drawing.Size(175, 14);
            this.makeErrorLabel.TabIndex = 8;
            this.makeErrorLabel.Text = "Please enter a valid make name";
            this.makeErrorLabel.Visible = false;
            // 
            // registrationNumberErrorLabel
            // 
            this.registrationNumberErrorLabel.AutoSize = true;
            this.registrationNumberErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.registrationNumberErrorLabel.Location = new System.Drawing.Point(151, 129);
            this.registrationNumberErrorLabel.Name = "registrationNumberErrorLabel";
            this.registrationNumberErrorLabel.Size = new System.Drawing.Size(189, 14);
            this.registrationNumberErrorLabel.TabIndex = 9;
            this.registrationNumberErrorLabel.Text = "Please enter a registration number";
            this.registrationNumberErrorLabel.Visible = false;
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.Color.Green;
            this.addVehicleButton.FlatAppearance.BorderSize = 2;
            this.addVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.addVehicleButton.Location = new System.Drawing.Point(89, 178);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(82, 23);
            this.addVehicleButton.TabIndex = 10;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Goldenrod;
            this.resetButton.FlatAppearance.BorderSize = 2;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.resetButton.Location = new System.Drawing.Point(196, 178);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Clear/Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.registrationNumberErrorLabel);
            this.Controls.Add(this.makeErrorLabel);
            this.Controls.Add(this.modelErrorLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Vehicle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddVehicleForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label modelErrorLabel;
        private System.Windows.Forms.Label makeErrorLabel;
        private System.Windows.Forms.Label registrationNumberErrorLabel;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button resetButton;
    }
}