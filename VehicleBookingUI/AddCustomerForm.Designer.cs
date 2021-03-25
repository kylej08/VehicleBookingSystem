
namespace VehicleBookingUI
{
    partial class AddCustomerForm
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.contactNumberErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.firstNameTextBox.Location = new System.Drawing.Point(144, 21);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lastNameTextBox.Location = new System.Drawing.Point(144, 64);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.contactNumberTextBox.Location = new System.Drawing.Point(144, 110);
            this.contactNumberTextBox.MaxLength = 10;
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.contactNumberTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.firstNameLabel.Location = new System.Drawing.Point(44, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(65, 14);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lastNameLabel.Location = new System.Drawing.Point(44, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 14);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.contactNumberLabel.Location = new System.Drawing.Point(44, 113);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(96, 14);
            this.contactNumberLabel.TabIndex = 6;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.Green;
            this.addCustomerButton.FlatAppearance.BorderSize = 2;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.addCustomerButton.Location = new System.Drawing.Point(89, 178);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(82, 23);
            this.addCustomerButton.TabIndex = 7;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
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
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Clear/Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // contactNumberErrorLabel
            // 
            this.contactNumberErrorLabel.AutoSize = true;
            this.contactNumberErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.contactNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.contactNumberErrorLabel.Location = new System.Drawing.Point(141, 133);
            this.contactNumberErrorLabel.Name = "contactNumberErrorLabel";
            this.contactNumberErrorLabel.Size = new System.Drawing.Size(198, 14);
            this.contactNumberErrorLabel.TabIndex = 9;
            this.contactNumberErrorLabel.Text = "Please enter a valid contact number";
            this.contactNumberErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(141, 87);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(168, 14);
            this.lastNameErrorLabel.TabIndex = 10;
            this.lastNameErrorLabel.Text = "Please enter  a valid last name";
            this.lastNameErrorLabel.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(141, 44);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(167, 14);
            this.firstNameErrorLabel.TabIndex = 11;
            this.firstNameErrorLabel.Text = "Please enter a valid first name";
            this.firstNameErrorLabel.Visible = false;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.contactNumberErrorLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.contactNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label contactNumberErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
    }
}