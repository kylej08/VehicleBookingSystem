
namespace VehicleBookingUI
{
    partial class ModifyVehiclesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registrationNumberErrorLabel = new System.Windows.Forms.Label();
            this.makeErrorLabel = new System.Windows.Forms.Label();
            this.modelErrorLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.vehiclesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationNumberErrorLabel
            // 
            this.registrationNumberErrorLabel.AutoSize = true;
            this.registrationNumberErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.registrationNumberErrorLabel.Location = new System.Drawing.Point(561, 550);
            this.registrationNumberErrorLabel.Name = "registrationNumberErrorLabel";
            this.registrationNumberErrorLabel.Size = new System.Drawing.Size(220, 14);
            this.registrationNumberErrorLabel.TabIndex = 31;
            this.registrationNumberErrorLabel.Text = "Please enter a valid registration number";
            this.registrationNumberErrorLabel.Visible = false;
            // 
            // makeErrorLabel
            // 
            this.makeErrorLabel.AutoSize = true;
            this.makeErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.makeErrorLabel.Location = new System.Drawing.Point(561, 508);
            this.makeErrorLabel.Name = "makeErrorLabel";
            this.makeErrorLabel.Size = new System.Drawing.Size(143, 14);
            this.makeErrorLabel.TabIndex = 30;
            this.makeErrorLabel.Text = "Please enter a valid make";
            this.makeErrorLabel.Visible = false;
            // 
            // modelErrorLabel
            // 
            this.modelErrorLabel.AutoSize = true;
            this.modelErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.modelErrorLabel.Location = new System.Drawing.Point(556, 465);
            this.modelErrorLabel.Name = "modelErrorLabel";
            this.modelErrorLabel.Size = new System.Drawing.Size(148, 14);
            this.modelErrorLabel.TabIndex = 29;
            this.modelErrorLabel.Text = "Please enter a valid model";
            this.modelErrorLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Goldenrod;
            this.resetButton.FlatAppearance.BorderSize = 2;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.resetButton.Location = new System.Drawing.Point(648, 591);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 34);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Clear/Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberLabel.Location = new System.Drawing.Point(434, 528);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(120, 14);
            this.registrationNumberLabel.TabIndex = 27;
            this.registrationNumberLabel.Text = "Registration Number";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeLabel.Location = new System.Drawing.Point(434, 486);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(38, 14);
            this.makeLabel.TabIndex = 26;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelLabel.Location = new System.Drawing.Point(434, 444);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(43, 14);
            this.modelLabel.TabIndex = 25;
            this.modelLabel.Text = "Model";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.idLabel.Location = new System.Drawing.Point(434, 406);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(63, 14);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "Unique ID";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Enabled = false;
            this.registrationNumberTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.registrationNumberTextBox.Location = new System.Drawing.Point(559, 525);
            this.registrationNumberTextBox.MaxLength = 10;
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(133, 22);
            this.registrationNumberTextBox.TabIndex = 23;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Enabled = false;
            this.makeTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.makeTextBox.Location = new System.Drawing.Point(559, 483);
            this.makeTextBox.MaxLength = 50;
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(133, 22);
            this.makeTextBox.TabIndex = 22;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.modelTextBox.Location = new System.Drawing.Point(559, 440);
            this.modelTextBox.MaxLength = 50;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(133, 22);
            this.modelTextBox.TabIndex = 21;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.idTextBox.Location = new System.Drawing.Point(559, 403);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(133, 22);
            this.idTextBox.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(535, 591);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 34);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 2;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.editButton.Location = new System.Drawing.Point(422, 591);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(98, 34);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AllowUserToAddRows = false;
            this.vehicleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            this.vehicleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.vehicleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicleDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.vehicleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vehicleDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.vehicleDataGridView.Location = new System.Drawing.Point(320, 65);
            this.vehicleDataGridView.MultiSelect = false;
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowHeadersVisible = false;
            this.vehicleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vehicleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleDataGridView.Size = new System.Drawing.Size(517, 308);
            this.vehicleDataGridView.TabIndex = 16;
            this.vehicleDataGridView.SelectionChanged += new System.EventHandler(this.vehicleDataGridView_SelectionChanged);
            // 
            // vehiclesLabel
            // 
            this.vehiclesLabel.AutoSize = true;
            this.vehiclesLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.vehiclesLabel.Location = new System.Drawing.Point(528, 20);
            this.vehiclesLabel.Name = "vehiclesLabel";
            this.vehiclesLabel.Size = new System.Drawing.Size(99, 26);
            this.vehiclesLabel.TabIndex = 32;
            this.vehiclesLabel.Text = "VEHICLES";
            // 
            // ModifyVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1138, 653);
            this.Controls.Add(this.vehiclesLabel);
            this.Controls.Add(this.registrationNumberErrorLabel);
            this.Controls.Add(this.makeErrorLabel);
            this.Controls.Add(this.modelErrorLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.vehicleDataGridView);
            this.Name = "ModifyVehiclesForm";
            this.Text = "ModifyVehiclesForm";
            this.VisibleChanged += new System.EventHandler(this.ModifyVehiclesForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationNumberErrorLabel;
        private System.Windows.Forms.Label makeErrorLabel;
        private System.Windows.Forms.Label modelErrorLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.Label vehiclesLabel;
    }
}