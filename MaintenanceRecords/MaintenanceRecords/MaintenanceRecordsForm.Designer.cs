namespace MaintenanceRecords
{
    partial class MaintenanceRecordsForm
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
            recordsListBox = new ListBox();
            ownerIDTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            ownerIDLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            notesLabel = new Label();
            registrationDateLabel = new Label();
            makeLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            colorLabel = new Label();
            vinLabel = new Label();
            recordsGroupBox = new GroupBox();
            serviceDateTimePicker = new DateTimePicker();
            registrationDateTimePicker = new DateTimePicker();
            serviceCheckedListBox = new CheckedListBox();
            notesTextBox = new TextBox();
            costTextBox = new TextBox();
            odometerTextBox = new TextBox();
            licensePlateTextBox = new TextBox();
            vinTextBox = new TextBox();
            colorTextBox = new TextBox();
            yearTextBox = new TextBox();
            modelTextBox = new TextBox();
            makeTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            serviceLabel = new Label();
            costLabel = new Label();
            serviceDateLabel = new Label();
            odometerLabel = new Label();
            licensePlateLabel = new Label();
            createButton = new Button();
            clearButton = new Button();
            recordsListView = new ListView();
            updateButton = new Button();
            recordsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // recordsListBox
            // 
            recordsListBox.BackColor = Color.PeachPuff;
            recordsListBox.FormattingEnabled = true;
            recordsListBox.ItemHeight = 25;
            recordsListBox.Location = new Point(9, 422);
            recordsListBox.Name = "recordsListBox";
            recordsListBox.Size = new Size(174, 254);
            recordsListBox.TabIndex = 1;
            recordsListBox.SelectedIndexChanged += recordListBox_SelectedIndexChanged;
            // 
            // ownerIDTextBox
            // 
            ownerIDTextBox.BackColor = Color.PeachPuff;
            ownerIDTextBox.Enabled = false;
            ownerIDTextBox.Location = new Point(169, 30);
            ownerIDTextBox.Name = "ownerIDTextBox";
            ownerIDTextBox.Size = new Size(300, 31);
            ownerIDTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.PeachPuff;
            firstNameTextBox.Location = new Point(169, 75);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(300, 31);
            firstNameTextBox.TabIndex = 1;
            // 
            // ownerIDLabel
            // 
            ownerIDLabel.AutoSize = true;
            ownerIDLabel.Location = new Point(70, 32);
            ownerIDLabel.Name = "ownerIDLabel";
            ownerIDLabel.Size = new Size(86, 25);
            ownerIDLabel.TabIndex = 20;
            ownerIDLabel.Text = "OwnerID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(60, 78);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(101, 25);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(61, 123);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(99, 25);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(103, 167);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(26, 212);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(136, 25);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(914, 37);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(63, 25);
            notesLabel.TabIndex = 34;
            notesLabel.Text = "Notes:";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Location = new Point(9, 260);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(152, 25);
            registrationDateLabel.TabIndex = 25;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(97, 303);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(59, 25);
            makeLabel.TabIndex = 26;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(546, 32);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(67, 25);
            modelLabel.TabIndex = 27;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(564, 78);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(48, 25);
            yearLabel.TabIndex = 28;
            yearLabel.Text = "Year:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(553, 123);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(59, 25);
            colorLabel.TabIndex = 29;
            colorLabel.Text = "Color:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new Point(501, 167);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(111, 25);
            vinLabel.TabIndex = 30;
            vinLabel.Text = "Vin Number:";
            // 
            // recordsGroupBox
            // 
            recordsGroupBox.BackColor = Color.DodgerBlue;
            recordsGroupBox.Controls.Add(serviceDateTimePicker);
            recordsGroupBox.Controls.Add(registrationDateTimePicker);
            recordsGroupBox.Controls.Add(serviceCheckedListBox);
            recordsGroupBox.Controls.Add(notesLabel);
            recordsGroupBox.Controls.Add(notesTextBox);
            recordsGroupBox.Controls.Add(costTextBox);
            recordsGroupBox.Controls.Add(odometerTextBox);
            recordsGroupBox.Controls.Add(makeLabel);
            recordsGroupBox.Controls.Add(licensePlateTextBox);
            recordsGroupBox.Controls.Add(vinTextBox);
            recordsGroupBox.Controls.Add(colorTextBox);
            recordsGroupBox.Controls.Add(yearTextBox);
            recordsGroupBox.Controls.Add(modelTextBox);
            recordsGroupBox.Controls.Add(makeTextBox);
            recordsGroupBox.Controls.Add(phoneNumberTextBox);
            recordsGroupBox.Controls.Add(emailTextBox);
            recordsGroupBox.Controls.Add(lastNameTextBox);
            recordsGroupBox.Controls.Add(serviceLabel);
            recordsGroupBox.Controls.Add(costLabel);
            recordsGroupBox.Controls.Add(serviceDateLabel);
            recordsGroupBox.Controls.Add(odometerLabel);
            recordsGroupBox.Controls.Add(licensePlateLabel);
            recordsGroupBox.Controls.Add(vinLabel);
            recordsGroupBox.Controls.Add(colorLabel);
            recordsGroupBox.Controls.Add(yearLabel);
            recordsGroupBox.Controls.Add(modelLabel);
            recordsGroupBox.Controls.Add(registrationDateLabel);
            recordsGroupBox.Controls.Add(phoneNumberLabel);
            recordsGroupBox.Controls.Add(emailLabel);
            recordsGroupBox.Controls.Add(lastNameLabel);
            recordsGroupBox.Controls.Add(firstNameLabel);
            recordsGroupBox.Controls.Add(ownerIDLabel);
            recordsGroupBox.Controls.Add(firstNameTextBox);
            recordsGroupBox.Controls.Add(ownerIDTextBox);
            recordsGroupBox.Location = new Point(11, -2);
            recordsGroupBox.Name = "recordsGroupBox";
            recordsGroupBox.Size = new Size(1300, 345);
            recordsGroupBox.TabIndex = 0;
            recordsGroupBox.TabStop = false;
            recordsGroupBox.Text = "Record";
            // 
            // serviceDateTimePicker
            // 
            serviceDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            serviceDateTimePicker.Location = new Point(984, 293);
            serviceDateTimePicker.Name = "serviceDateTimePicker";
            serviceDateTimePicker.Size = new Size(300, 31);
            serviceDateTimePicker.TabIndex = 16;
            serviceDateTimePicker.Value = new DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // registrationDateTimePicker
            // 
            registrationDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            registrationDateTimePicker.Location = new Point(169, 253);
            registrationDateTimePicker.Name = "registrationDateTimePicker";
            registrationDateTimePicker.Size = new Size(300, 31);
            registrationDateTimePicker.TabIndex = 5;
            registrationDateTimePicker.Value = new DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // serviceCheckedListBox
            // 
            serviceCheckedListBox.BackColor = Color.PeachPuff;
            serviceCheckedListBox.FormattingEnabled = true;
            serviceCheckedListBox.Items.AddRange(new object[] { "Oil Change", "A/C System Inspection/Recharge", "Air Filter Replacement", "Ball Joint Replacement", "Battery Check/Replacement", "Brake Caliper Replacement", "Brake Fluid Flush", "Brake Inspection", "Brake Pad Replacement", "Coolant Flush", "Engine Diagnostic Scan", "Engine Tune-Up", "Fuel Filter Replacement", "Fuel Injector Cleaning", "Fuel Pump Replacement", "Oxygen Sensor Replacement", "Serpentine Belt Replacement", "Shock and Strut Replacement", "Spark Plug Replacement", "Suspension Check", "Suspension Service", "Thermostat Replacement", "Tie Rod End Replacement", "Timing Belt Replacement", "Tire Rotation", "Transmission Flush", "Transmission Service", "Wheel Alignment", "Wheel Balancing", "Wheel Bearing Replacement", "Wheel Hub Assembly Replacement" });
            serviceCheckedListBox.Location = new Point(984, 95);
            serviceCheckedListBox.Name = "serviceCheckedListBox";
            serviceCheckedListBox.Size = new Size(300, 116);
            serviceCheckedListBox.TabIndex = 15;
            // 
            // notesTextBox
            // 
            notesTextBox.BackColor = Color.PeachPuff;
            notesTextBox.Location = new Point(984, 32);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(300, 31);
            notesTextBox.TabIndex = 14;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.PeachPuff;
            costTextBox.Location = new Point(619, 297);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(245, 31);
            costTextBox.TabIndex = 13;
            // 
            // odometerTextBox
            // 
            odometerTextBox.BackColor = Color.PeachPuff;
            odometerTextBox.Location = new Point(619, 253);
            odometerTextBox.Name = "odometerTextBox";
            odometerTextBox.Size = new Size(245, 31);
            odometerTextBox.TabIndex = 12;
            // 
            // licensePlateTextBox
            // 
            licensePlateTextBox.BackColor = Color.PeachPuff;
            licensePlateTextBox.Location = new Point(619, 208);
            licensePlateTextBox.Name = "licensePlateTextBox";
            licensePlateTextBox.Size = new Size(245, 31);
            licensePlateTextBox.TabIndex = 11;
            // 
            // vinTextBox
            // 
            vinTextBox.BackColor = Color.PeachPuff;
            vinTextBox.Location = new Point(619, 163);
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(245, 31);
            vinTextBox.TabIndex = 10;
            // 
            // colorTextBox
            // 
            colorTextBox.BackColor = Color.PeachPuff;
            colorTextBox.Location = new Point(619, 122);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(245, 31);
            colorTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.PeachPuff;
            yearTextBox.Location = new Point(619, 75);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(245, 31);
            yearTextBox.TabIndex = 8;
            // 
            // modelTextBox
            // 
            modelTextBox.BackColor = Color.PeachPuff;
            modelTextBox.Location = new Point(619, 30);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(245, 31);
            modelTextBox.TabIndex = 7;
            // 
            // makeTextBox
            // 
            makeTextBox.BackColor = Color.PeachPuff;
            makeTextBox.Location = new Point(169, 298);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(300, 31);
            makeTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.PeachPuff;
            phoneNumberTextBox.Location = new Point(169, 208);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(300, 31);
            phoneNumberTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.PeachPuff;
            emailTextBox.Location = new Point(169, 163);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 31);
            emailTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.PeachPuff;
            lastNameTextBox.Location = new Point(169, 120);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(300, 31);
            lastNameTextBox.TabIndex = 2;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(907, 168);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(71, 25);
            serviceLabel.TabIndex = 35;
            serviceLabel.Text = "Service:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(477, 300);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(135, 25);
            costLabel.TabIndex = 33;
            costLabel.Text = "Estimated Cost:";
            // 
            // serviceDateLabel
            // 
            serviceDateLabel.AutoSize = true;
            serviceDateLabel.Location = new Point(866, 298);
            serviceDateLabel.Name = "serviceDateLabel";
            serviceDateLabel.Size = new Size(113, 25);
            serviceDateLabel.TabIndex = 36;
            serviceDateLabel.Text = "Service Date:";
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new Point(514, 257);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new Size(98, 25);
            odometerLabel.TabIndex = 32;
            odometerLabel.Text = "Odometer:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new Point(497, 213);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new Size(115, 25);
            licensePlateLabel.TabIndex = 31;
            licensePlateLabel.Text = "License Plate:";
            // 
            // createButton
            // 
            createButton.BackColor = Color.Green;
            createButton.Location = new Point(679, 368);
            createButton.Name = "createButton";
            createButton.Size = new Size(123, 47);
            createButton.TabIndex = 14;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.LimeGreen;
            clearButton.Location = new Point(63, 368);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(123, 47);
            clearButton.TabIndex = 18;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // recordsListView
            // 
            recordsListView.BackColor = Color.PeachPuff;
            recordsListView.Location = new Point(190, 422);
            recordsListView.Name = "recordsListView";
            recordsListView.Size = new Size(1121, 254);
            recordsListView.TabIndex = 18;
            recordsListView.UseCompatibleStateImageBehavior = false;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Crimson;
            updateButton.Location = new Point(191, 368);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(123, 47);
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // MaintenanceRecordsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1323, 692);
            Controls.Add(updateButton);
            Controls.Add(recordsListView);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Controls.Add(recordsListBox);
            Controls.Add(recordsGroupBox);
            Name = "MaintenanceRecordsForm";
            Text = "Maintenance Records";
            Load += MaintenanceRecordsForm_Load;
            recordsGroupBox.ResumeLayout(false);
            recordsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox recordsListBox;
        private TextBox ownerIDTextBox;
        private TextBox firstNameTextBox;
        private Label ownerIDLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label notesLabel;
        private Label registrationDateLabel;
        private Label makeLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label colorLabel;
        private Label vinLabel;
        private GroupBox recordsGroupBox;
        private TextBox notesTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private Label serviceLabel;
        private Label costLabel;
        private Label serviceDateLabel;
        private Label odometerLabel;
        private Label licensePlateLabel;
        private DateTimePicker serviceDateTimePicker;
        private DateTimePicker registrationDateTimePicker;
        private CheckedListBox serviceCheckedListBox;
        private TextBox costTextBox;
        private TextBox odometerTextBox;
        private TextBox licensePlateTextBox;
        private TextBox vinTextBox;
        private TextBox colorTextBox;
        private TextBox yearTextBox;
        private TextBox modelTextBox;
        private TextBox makeTextBox;
        private Button createButton;
        private Button clearButton;
        private DataGridView recordsDataGridView;
        private ListView recordsListView;
        private Button updateButton;
    }
}