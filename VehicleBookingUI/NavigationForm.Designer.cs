
namespace VehicleBookingUI
{
    partial class NavigationForm
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
            this.navigationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.fictitiousCompanyLabel = new System.Windows.Forms.Label();
            this.fictitiousCopyrightLabel = new System.Windows.Forms.Label();
            this.vehiclesFormButton = new System.Windows.Forms.Button();
            this.editFormButton = new System.Windows.Forms.Button();
            this.bookingFormButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightNoticeLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navigationSplitContainer)).BeginInit();
            this.navigationSplitContainer.Panel1.SuspendLayout();
            this.navigationSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationSplitContainer
            // 
            this.navigationSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.navigationSplitContainer.Name = "navigationSplitContainer";
            // 
            // navigationSplitContainer.Panel1
            // 
            this.navigationSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.navigationSplitContainer.Panel1.Controls.Add(this.fictitiousCompanyLabel);
            this.navigationSplitContainer.Panel1.Controls.Add(this.fictitiousCopyrightLabel);
            this.navigationSplitContainer.Panel1.Controls.Add(this.vehiclesFormButton);
            this.navigationSplitContainer.Panel1.Controls.Add(this.editFormButton);
            this.navigationSplitContainer.Panel1.Controls.Add(this.bookingFormButton);
            this.navigationSplitContainer.Panel1.Controls.Add(this.pictureBox1);
            this.navigationSplitContainer.Panel1.Controls.Add(this.copyrightNoticeLabel);
            this.navigationSplitContainer.Panel1.Controls.Add(this.companyNameLabel);
            this.navigationSplitContainer.Panel1MinSize = 250;
            this.navigationSplitContainer.Size = new System.Drawing.Size(1390, 654);
            this.navigationSplitContainer.SplitterDistance = 250;
            this.navigationSplitContainer.TabIndex = 1;
            // 
            // fictitiousCompanyLabel
            // 
            this.fictitiousCompanyLabel.AutoSize = true;
            this.fictitiousCompanyLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fictitiousCompanyLabel.Location = new System.Drawing.Point(91, 115);
            this.fictitiousCompanyLabel.Name = "fictitiousCompanyLabel";
            this.fictitiousCompanyLabel.Size = new System.Drawing.Size(60, 14);
            this.fictitiousCompanyLabel.TabIndex = 7;
            this.fictitiousCompanyLabel.Text = "(Fictitious)";
            // 
            // fictitiousCopyrightLabel
            // 
            this.fictitiousCopyrightLabel.AutoSize = true;
            this.fictitiousCopyrightLabel.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fictitiousCopyrightLabel.Location = new System.Drawing.Point(91, 613);
            this.fictitiousCopyrightLabel.Name = "fictitiousCopyrightLabel";
            this.fictitiousCopyrightLabel.Size = new System.Drawing.Size(60, 14);
            this.fictitiousCopyrightLabel.TabIndex = 6;
            this.fictitiousCopyrightLabel.Text = "(Fictitious)";
            // 
            // vehiclesFormButton
            // 
            this.vehiclesFormButton.BackColor = System.Drawing.Color.Black;
            this.vehiclesFormButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.vehiclesFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiclesFormButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.vehiclesFormButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vehiclesFormButton.Location = new System.Drawing.Point(58, 276);
            this.vehiclesFormButton.Name = "vehiclesFormButton";
            this.vehiclesFormButton.Size = new System.Drawing.Size(133, 28);
            this.vehiclesFormButton.TabIndex = 5;
            this.vehiclesFormButton.Text = "Vehicles";
            this.vehiclesFormButton.UseVisualStyleBackColor = false;
            this.vehiclesFormButton.Click += new System.EventHandler(this.vehiclesFormButton_Click);
            // 
            // editFormButton
            // 
            this.editFormButton.BackColor = System.Drawing.Color.Black;
            this.editFormButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.editFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFormButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.editFormButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editFormButton.Location = new System.Drawing.Point(58, 215);
            this.editFormButton.Name = "editFormButton";
            this.editFormButton.Size = new System.Drawing.Size(133, 28);
            this.editFormButton.TabIndex = 4;
            this.editFormButton.Text = "Customers";
            this.editFormButton.UseVisualStyleBackColor = false;
            this.editFormButton.Click += new System.EventHandler(this.editFormButton_Click);
            // 
            // bookingFormButton
            // 
            this.bookingFormButton.BackColor = System.Drawing.Color.Black;
            this.bookingFormButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bookingFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingFormButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingFormButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookingFormButton.Location = new System.Drawing.Point(58, 156);
            this.bookingFormButton.Name = "bookingFormButton";
            this.bookingFormButton.Size = new System.Drawing.Size(133, 28);
            this.bookingFormButton.TabIndex = 3;
            this.bookingFormButton.Text = "Bookings";
            this.bookingFormButton.UseVisualStyleBackColor = false;
            this.bookingFormButton.Click += new System.EventHandler(this.bookingFormButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleBookingUI.Properties.Resources.CarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(41, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightNoticeLabel
            // 
            this.copyrightNoticeLabel.AutoSize = true;
            this.copyrightNoticeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.copyrightNoticeLabel.Location = new System.Drawing.Point(75, 599);
            this.copyrightNoticeLabel.Name = "copyrightNoticeLabel";
            this.copyrightNoticeLabel.Size = new System.Drawing.Size(94, 14);
            this.copyrightNoticeLabel.TabIndex = 1;
            this.copyrightNoticeLabel.Text = "Copyright 2021";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.companyNameLabel.Location = new System.Drawing.Point(34, 101);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(178, 14);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Automobile Software Company";
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1414, 678);
            this.Controls.Add(this.navigationSplitContainer);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.navigationSplitContainer.Panel1.ResumeLayout(false);
            this.navigationSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationSplitContainer)).EndInit();
            this.navigationSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer navigationSplitContainer;
        private System.Windows.Forms.Button editFormButton;
        private System.Windows.Forms.Button bookingFormButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label copyrightNoticeLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Button vehiclesFormButton;
        private System.Windows.Forms.Label fictitiousCompanyLabel;
        private System.Windows.Forms.Label fictitiousCopyrightLabel;
    }
}