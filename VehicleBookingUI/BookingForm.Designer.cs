
namespace VehicleBookingUI
{
    partial class BookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.notesErrorLabel = new System.Windows.Forms.Label();
            this.bookingsListLabel = new System.Windows.Forms.Label();
            this.existingVehiclesErrorLabel = new System.Windows.Forms.Label();
            this.bookingsFilterComboBox = new System.Windows.Forms.ComboBox();
            this.existingCustomersErrorLabel = new System.Windows.Forms.Label();
            this.bookingsFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeErrorLabel = new System.Windows.Forms.Label();
            this.bookingsFilterLabel = new System.Windows.Forms.Label();
            this.createNewBookingLabel = new System.Windows.Forms.Label();
            this.bookingResetButton = new System.Windows.Forms.Button();
            this.bookingStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.bookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.bookingEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookingDateLabel = new System.Windows.Forms.Label();
            this.bookingNotesLabel = new System.Windows.Forms.Label();
            this.bookingStartTimeLabel = new System.Windows.Forms.Label();
            this.bookingNotesTextBox = new System.Windows.Forms.TextBox();
            this.bookingEndTimeLabel = new System.Windows.Forms.Label();
            this.bookingVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.existingCustomersLabel = new System.Windows.Forms.Label();
            this.bookingCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.existingVehiclesLabel = new System.Windows.Forms.Label();
            this.bookingNowButton = new System.Windows.Forms.Button();
            this.deleteBookingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.bookingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.bookingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookingDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookingDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bookingDataGridView.Location = new System.Drawing.Point(25, 161);
            this.bookingDataGridView.MultiSelect = false;
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bookingDataGridView.RowHeadersVisible = false;
            this.bookingDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(667, 424);
            this.bookingDataGridView.TabIndex = 56;
            this.bookingDataGridView.SelectionChanged += new System.EventHandler(this.bookingDataGridView_SelectionChanged);
            // 
            // notesErrorLabel
            // 
            this.notesErrorLabel.AutoSize = true;
            this.notesErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.notesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.notesErrorLabel.Location = new System.Drawing.Point(801, 458);
            this.notesErrorLabel.Name = "notesErrorLabel";
            this.notesErrorLabel.Size = new System.Drawing.Size(141, 14);
            this.notesErrorLabel.TabIndex = 63;
            this.notesErrorLabel.Text = "Error: please enter a note";
            this.notesErrorLabel.Visible = false;
            // 
            // bookingsListLabel
            // 
            this.bookingsListLabel.AutoSize = true;
            this.bookingsListLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsListLabel.Location = new System.Drawing.Point(270, 40);
            this.bookingsListLabel.Name = "bookingsListLabel";
            this.bookingsListLabel.Size = new System.Drawing.Size(184, 26);
            this.bookingsListLabel.TabIndex = 64;
            this.bookingsListLabel.Text = "LIST OF BOOKINGS";
            // 
            // existingVehiclesErrorLabel
            // 
            this.existingVehiclesErrorLabel.AutoSize = true;
            this.existingVehiclesErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.existingVehiclesErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.existingVehiclesErrorLabel.Location = new System.Drawing.Point(801, 377);
            this.existingVehiclesErrorLabel.Name = "existingVehiclesErrorLabel";
            this.existingVehiclesErrorLabel.Size = new System.Drawing.Size(161, 14);
            this.existingVehiclesErrorLabel.TabIndex = 62;
            this.existingVehiclesErrorLabel.Text = "Error: please select a vehicle";
            this.existingVehiclesErrorLabel.Visible = false;
            // 
            // bookingsFilterComboBox
            // 
            this.bookingsFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingsFilterComboBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingsFilterComboBox.FormattingEnabled = true;
            this.bookingsFilterComboBox.Items.AddRange(new object[] {
            "Show All",
            "Date"});
            this.bookingsFilterComboBox.Location = new System.Drawing.Point(198, 109);
            this.bookingsFilterComboBox.Name = "bookingsFilterComboBox";
            this.bookingsFilterComboBox.Size = new System.Drawing.Size(121, 22);
            this.bookingsFilterComboBox.TabIndex = 58;
            this.bookingsFilterComboBox.SelectedValueChanged += new System.EventHandler(this.bookingsFilterComboBox_SelectedValueChanged);
            // 
            // existingCustomersErrorLabel
            // 
            this.existingCustomersErrorLabel.AutoSize = true;
            this.existingCustomersErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.existingCustomersErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.existingCustomersErrorLabel.Location = new System.Drawing.Point(801, 315);
            this.existingCustomersErrorLabel.Name = "existingCustomersErrorLabel";
            this.existingCustomersErrorLabel.Size = new System.Drawing.Size(170, 14);
            this.existingCustomersErrorLabel.TabIndex = 61;
            this.existingCustomersErrorLabel.Text = "Error: please select a customer";
            this.existingCustomersErrorLabel.Visible = false;
            // 
            // bookingsFilterDateTimePicker
            // 
            this.bookingsFilterDateTimePicker.Enabled = false;
            this.bookingsFilterDateTimePicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingsFilterDateTimePicker.Location = new System.Drawing.Point(367, 110);
            this.bookingsFilterDateTimePicker.Name = "bookingsFilterDateTimePicker";
            this.bookingsFilterDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.bookingsFilterDateTimePicker.TabIndex = 57;
            this.bookingsFilterDateTimePicker.ValueChanged += new System.EventHandler(this.bookingsFilterDateTimePicker_ValueChanged);
            this.bookingsFilterDateTimePicker.EnabledChanged += new System.EventHandler(this.bookingsFilterDateTimePicker_EnabledChanged);
            // 
            // endTimeErrorLabel
            // 
            this.endTimeErrorLabel.AutoSize = true;
            this.endTimeErrorLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.endTimeErrorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.endTimeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endTimeErrorLabel.Location = new System.Drawing.Point(801, 214);
            this.endTimeErrorLabel.Name = "endTimeErrorLabel";
            this.endTimeErrorLabel.Size = new System.Drawing.Size(259, 14);
            this.endTimeErrorLabel.TabIndex = 60;
            this.endTimeErrorLabel.Text = "Error: the end time has to be after the start time";
            this.endTimeErrorLabel.Visible = false;
            // 
            // bookingsFilterLabel
            // 
            this.bookingsFilterLabel.AutoSize = true;
            this.bookingsFilterLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingsFilterLabel.Location = new System.Drawing.Point(137, 112);
            this.bookingsFilterLabel.Name = "bookingsFilterLabel";
            this.bookingsFilterLabel.Size = new System.Drawing.Size(55, 14);
            this.bookingsFilterLabel.TabIndex = 45;
            this.bookingsFilterLabel.Text = "Filter By";
            // 
            // createNewBookingLabel
            // 
            this.createNewBookingLabel.AutoSize = true;
            this.createNewBookingLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewBookingLabel.Location = new System.Drawing.Point(810, 40);
            this.createNewBookingLabel.Name = "createNewBookingLabel";
            this.createNewBookingLabel.Size = new System.Drawing.Size(224, 26);
            this.createNewBookingLabel.TabIndex = 59;
            this.createNewBookingLabel.Text = "CREATE NEW BOOKING";
            // 
            // bookingResetButton
            // 
            this.bookingResetButton.BackColor = System.Drawing.Color.Goldenrod;
            this.bookingResetButton.FlatAppearance.BorderSize = 2;
            this.bookingResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingResetButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingResetButton.Location = new System.Drawing.Point(930, 538);
            this.bookingResetButton.Name = "bookingResetButton";
            this.bookingResetButton.Size = new System.Drawing.Size(116, 47);
            this.bookingResetButton.TabIndex = 55;
            this.bookingResetButton.Text = "Clear/Reset";
            this.bookingResetButton.UseVisualStyleBackColor = false;
            this.bookingResetButton.Click += new System.EventHandler(this.bookingResetButton_Click);
            // 
            // bookingStartTimePicker
            // 
            this.bookingStartTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.bookingStartTimePicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingStartTimePicker.Location = new System.Drawing.Point(804, 147);
            this.bookingStartTimePicker.Name = "bookingStartTimePicker";
            this.bookingStartTimePicker.Size = new System.Drawing.Size(199, 22);
            this.bookingStartTimePicker.TabIndex = 39;
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addVehicleButton.FlatAppearance.BorderSize = 2;
            this.addVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.addVehicleButton.ForeColor = System.Drawing.Color.Black;
            this.addVehicleButton.Location = new System.Drawing.Point(986, 351);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(126, 24);
            this.addVehicleButton.TabIndex = 54;
            this.addVehicleButton.Text = "Add New Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // bookingDateTimePicker
            // 
            this.bookingDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookingDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.bookingDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.bookingDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookingDateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.bookingDateTimePicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingDateTimePicker.Location = new System.Drawing.Point(804, 110);
            this.bookingDateTimePicker.MinDate = new System.DateTime(2021, 3, 23, 0, 0, 0, 0);
            this.bookingDateTimePicker.Name = "bookingDateTimePicker";
            this.bookingDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.bookingDateTimePicker.TabIndex = 40;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addCustomerButton.FlatAppearance.BorderSize = 2;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.addCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.addCustomerButton.Location = new System.Drawing.Point(986, 291);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(126, 24);
            this.addCustomerButton.TabIndex = 53;
            this.addCustomerButton.Text = "Add New Customer";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // bookingEndTimePicker
            // 
            this.bookingEndTimePicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingEndTimePicker.Location = new System.Drawing.Point(804, 191);
            this.bookingEndTimePicker.Name = "bookingEndTimePicker";
            this.bookingEndTimePicker.Size = new System.Drawing.Size(200, 22);
            this.bookingEndTimePicker.TabIndex = 41;
            // 
            // bookingDateLabel
            // 
            this.bookingDateLabel.AutoSize = true;
            this.bookingDateLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingDateLabel.Location = new System.Drawing.Point(724, 116);
            this.bookingDateLabel.Name = "bookingDateLabel";
            this.bookingDateLabel.Size = new System.Drawing.Size(32, 14);
            this.bookingDateLabel.TabIndex = 42;
            this.bookingDateLabel.Text = "Date";
            // 
            // bookingNotesLabel
            // 
            this.bookingNotesLabel.AutoSize = true;
            this.bookingNotesLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingNotesLabel.Location = new System.Drawing.Point(724, 436);
            this.bookingNotesLabel.Name = "bookingNotesLabel";
            this.bookingNotesLabel.Size = new System.Drawing.Size(38, 14);
            this.bookingNotesLabel.TabIndex = 51;
            this.bookingNotesLabel.Text = "Notes";
            // 
            // bookingStartTimeLabel
            // 
            this.bookingStartTimeLabel.AutoSize = true;
            this.bookingStartTimeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingStartTimeLabel.Location = new System.Drawing.Point(724, 153);
            this.bookingStartTimeLabel.Name = "bookingStartTimeLabel";
            this.bookingStartTimeLabel.Size = new System.Drawing.Size(63, 14);
            this.bookingStartTimeLabel.TabIndex = 43;
            this.bookingStartTimeLabel.Text = "Start Time";
            // 
            // bookingNotesTextBox
            // 
            this.bookingNotesTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingNotesTextBox.Location = new System.Drawing.Point(804, 433);
            this.bookingNotesTextBox.MaxLength = 25;
            this.bookingNotesTextBox.Name = "bookingNotesTextBox";
            this.bookingNotesTextBox.Size = new System.Drawing.Size(175, 22);
            this.bookingNotesTextBox.TabIndex = 50;
            // 
            // bookingEndTimeLabel
            // 
            this.bookingEndTimeLabel.AutoSize = true;
            this.bookingEndTimeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingEndTimeLabel.Location = new System.Drawing.Point(724, 197);
            this.bookingEndTimeLabel.Name = "bookingEndTimeLabel";
            this.bookingEndTimeLabel.Size = new System.Drawing.Size(60, 14);
            this.bookingEndTimeLabel.TabIndex = 44;
            this.bookingEndTimeLabel.Text = "End Time";
            // 
            // bookingVehicleComboBox
            // 
            this.bookingVehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingVehicleComboBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingVehicleComboBox.FormattingEnabled = true;
            this.bookingVehicleComboBox.Location = new System.Drawing.Point(804, 353);
            this.bookingVehicleComboBox.Name = "bookingVehicleComboBox";
            this.bookingVehicleComboBox.Size = new System.Drawing.Size(163, 22);
            this.bookingVehicleComboBox.TabIndex = 49;
            // 
            // existingCustomersLabel
            // 
            this.existingCustomersLabel.AutoSize = true;
            this.existingCustomersLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.existingCustomersLabel.Location = new System.Drawing.Point(724, 295);
            this.existingCustomersLabel.Name = "existingCustomersLabel";
            this.existingCustomersLabel.Size = new System.Drawing.Size(59, 14);
            this.existingCustomersLabel.TabIndex = 46;
            this.existingCustomersLabel.Text = "Customer";
            // 
            // bookingCustomerComboBox
            // 
            this.bookingCustomerComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bookingCustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookingCustomerComboBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.bookingCustomerComboBox.FormattingEnabled = true;
            this.bookingCustomerComboBox.Location = new System.Drawing.Point(804, 291);
            this.bookingCustomerComboBox.Name = "bookingCustomerComboBox";
            this.bookingCustomerComboBox.Size = new System.Drawing.Size(163, 22);
            this.bookingCustomerComboBox.TabIndex = 48;
            this.bookingCustomerComboBox.Tag = "";
            // 
            // existingVehiclesLabel
            // 
            this.existingVehiclesLabel.AutoSize = true;
            this.existingVehiclesLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.existingVehiclesLabel.Location = new System.Drawing.Point(724, 356);
            this.existingVehiclesLabel.Name = "existingVehiclesLabel";
            this.existingVehiclesLabel.Size = new System.Drawing.Size(49, 14);
            this.existingVehiclesLabel.TabIndex = 47;
            this.existingVehiclesLabel.Text = "Vehicle";
            // 
            // bookingNowButton
            // 
            this.bookingNowButton.BackColor = System.Drawing.Color.Green;
            this.bookingNowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bookingNowButton.FlatAppearance.BorderSize = 2;
            this.bookingNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingNowButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingNowButton.Location = new System.Drawing.Point(793, 538);
            this.bookingNowButton.Name = "bookingNowButton";
            this.bookingNowButton.Size = new System.Drawing.Size(116, 47);
            this.bookingNowButton.TabIndex = 65;
            this.bookingNowButton.Text = "Book Now";
            this.bookingNowButton.UseVisualStyleBackColor = false;
            this.bookingNowButton.Click += new System.EventHandler(this.bookingNowButton_Click);
            // 
            // deleteBookingButton
            // 
            this.deleteBookingButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBookingButton.Enabled = false;
            this.deleteBookingButton.FlatAppearance.BorderSize = 2;
            this.deleteBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookingButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookingButton.Location = new System.Drawing.Point(288, 594);
            this.deleteBookingButton.Name = "deleteBookingButton";
            this.deleteBookingButton.Size = new System.Drawing.Size(116, 47);
            this.deleteBookingButton.TabIndex = 66;
            this.deleteBookingButton.Text = "Delete Booking";
            this.deleteBookingButton.UseVisualStyleBackColor = false;
            this.deleteBookingButton.Click += new System.EventHandler(this.deleteBookingButton_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1138, 653);
            this.Controls.Add(this.deleteBookingButton);
            this.Controls.Add(this.bookingNowButton);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.notesErrorLabel);
            this.Controls.Add(this.bookingsListLabel);
            this.Controls.Add(this.existingVehiclesErrorLabel);
            this.Controls.Add(this.bookingsFilterComboBox);
            this.Controls.Add(this.existingCustomersErrorLabel);
            this.Controls.Add(this.bookingsFilterDateTimePicker);
            this.Controls.Add(this.endTimeErrorLabel);
            this.Controls.Add(this.bookingsFilterLabel);
            this.Controls.Add(this.createNewBookingLabel);
            this.Controls.Add(this.bookingResetButton);
            this.Controls.Add(this.bookingStartTimePicker);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.bookingDateTimePicker);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.bookingEndTimePicker);
            this.Controls.Add(this.bookingDateLabel);
            this.Controls.Add(this.bookingNotesLabel);
            this.Controls.Add(this.bookingStartTimeLabel);
            this.Controls.Add(this.bookingNotesTextBox);
            this.Controls.Add(this.bookingEndTimeLabel);
            this.Controls.Add(this.bookingVehicleComboBox);
            this.Controls.Add(this.existingCustomersLabel);
            this.Controls.Add(this.bookingCustomerComboBox);
            this.Controls.Add(this.existingVehiclesLabel);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.VisibleChanged += new System.EventHandler(this.BookingForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Label notesErrorLabel;
        private System.Windows.Forms.Label bookingsListLabel;
        private System.Windows.Forms.Label existingVehiclesErrorLabel;
        private System.Windows.Forms.ComboBox bookingsFilterComboBox;
        private System.Windows.Forms.Label existingCustomersErrorLabel;
        private System.Windows.Forms.DateTimePicker bookingsFilterDateTimePicker;
        private System.Windows.Forms.Label endTimeErrorLabel;
        private System.Windows.Forms.Label bookingsFilterLabel;
        private System.Windows.Forms.Label createNewBookingLabel;
        private System.Windows.Forms.Button bookingResetButton;
        private System.Windows.Forms.DateTimePicker bookingStartTimePicker;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.DateTimePicker bookingDateTimePicker;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.DateTimePicker bookingEndTimePicker;
        private System.Windows.Forms.Label bookingDateLabel;
        private System.Windows.Forms.Label bookingNotesLabel;
        private System.Windows.Forms.Label bookingStartTimeLabel;
        private System.Windows.Forms.TextBox bookingNotesTextBox;
        private System.Windows.Forms.Label bookingEndTimeLabel;
        private System.Windows.Forms.ComboBox bookingVehicleComboBox;
        private System.Windows.Forms.Label existingCustomersLabel;
        private System.Windows.Forms.ComboBox bookingCustomerComboBox;
        private System.Windows.Forms.Label existingVehiclesLabel;
        private System.Windows.Forms.Button bookingNowButton;
        private System.Windows.Forms.Button deleteBookingButton;
    }
}

