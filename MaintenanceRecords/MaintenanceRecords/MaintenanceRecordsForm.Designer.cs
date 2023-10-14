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
            deleteButton = new Button();
            updateButton = new Button();
            deleteCheckBox = new CheckBox();
            recordsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // recordsListBox
            // 
            recordsListBox.BackColor = Color.PeachPuff;
            recordsListBox.FormattingEnabled = true;
            recordsListBox.ItemHeight = 15;
            recordsListBox.Location = new Point(6, 253);
            recordsListBox.Margin = new Padding(2);
            recordsListBox.Name = "recordsListBox";
            recordsListBox.Size = new Size(123, 154);
            recordsListBox.TabIndex = 1;
            recordsListBox.SelectedIndexChanged += recordListBox_SelectedIndexChanged;
            // 
            // ownerIDTextBox
            // 
            ownerIDTextBox.BackColor = Color.PeachPuff;
            ownerIDTextBox.Enabled = false;
            ownerIDTextBox.Location = new Point(118, 18);
            ownerIDTextBox.Margin = new Padding(2);
            ownerIDTextBox.Name = "ownerIDTextBox";
            ownerIDTextBox.Size = new Size(211, 23);
            ownerIDTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.PeachPuff;
            firstNameTextBox.Location = new Point(118, 45);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(211, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // ownerIDLabel
            // 
            ownerIDLabel.AutoSize = true;
            ownerIDLabel.Location = new Point(49, 19);
            ownerIDLabel.Margin = new Padding(2, 0, 2, 0);
            ownerIDLabel.Name = "ownerIDLabel";
            ownerIDLabel.Size = new Size(56, 15);
            ownerIDLabel.TabIndex = 20;
            ownerIDLabel.Text = "OwnerID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(42, 47);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(43, 74);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(66, 15);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(72, 100);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(18, 127);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(640, 22);
            notesLabel.Margin = new Padding(2, 0, 2, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(41, 15);
            notesLabel.TabIndex = 34;
            notesLabel.Text = "Notes:";
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Location = new Point(6, 156);
            registrationDateLabel.Margin = new Padding(2, 0, 2, 0);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(100, 15);
            registrationDateLabel.TabIndex = 25;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(68, 182);
            makeLabel.Margin = new Padding(2, 0, 2, 0);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(39, 15);
            makeLabel.TabIndex = 26;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(382, 19);
            modelLabel.Margin = new Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(44, 15);
            modelLabel.TabIndex = 27;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(395, 47);
            yearLabel.Margin = new Padding(2, 0, 2, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 28;
            yearLabel.Text = "Year:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(387, 74);
            colorLabel.Margin = new Padding(2, 0, 2, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(39, 15);
            colorLabel.TabIndex = 29;
            colorLabel.Text = "Color:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new Point(351, 100);
            vinLabel.Margin = new Padding(2, 0, 2, 0);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(74, 15);
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
            recordsGroupBox.Location = new Point(8, -1);
            recordsGroupBox.Margin = new Padding(2);
            recordsGroupBox.Name = "recordsGroupBox";
            recordsGroupBox.Padding = new Padding(2);
            recordsGroupBox.Size = new Size(910, 207);
            recordsGroupBox.TabIndex = 0;
            recordsGroupBox.TabStop = false;
            recordsGroupBox.Text = "Record";
            // 
            // serviceDateTimePicker
            // 
            serviceDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            serviceDateTimePicker.Location = new Point(689, 176);
            serviceDateTimePicker.Margin = new Padding(2);
            serviceDateTimePicker.Name = "serviceDateTimePicker";
            serviceDateTimePicker.Size = new Size(211, 23);
            serviceDateTimePicker.TabIndex = 16;
            serviceDateTimePicker.Value = new DateTime(2023, 10, 11, 0, 0, 0, 0);
            // 
            // registrationDateTimePicker
            // 
            registrationDateTimePicker.CalendarMonthBackground = Color.PeachPuff;
            registrationDateTimePicker.Location = new Point(118, 152);
            registrationDateTimePicker.Margin = new Padding(2);
            registrationDateTimePicker.Name = "registrationDateTimePicker";
            registrationDateTimePicker.Size = new Size(211, 23);
            registrationDateTimePicker.TabIndex = 5;
            registrationDateTimePicker.Value = new DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // serviceCheckedListBox
            // 
            serviceCheckedListBox.BackColor = Color.PeachPuff;
            serviceCheckedListBox.FormattingEnabled = true;
            serviceCheckedListBox.Items.AddRange(new object[] { "Oil Change", "A/C System Inspection/Recharge", "Air Filter Replacement", "Ball Joint Replacement", "Battery Check/Replacement", "Brake Caliper Replacement", "Brake Fluid Flush", "Brake Inspection", "Brake Pad Replacement", "Coolant Flush", "Engine Diagnostic Scan", "Engine Tune-Up", "Fuel Filter Replacement", "Fuel Injector Cleaning", "Fuel Pump Replacement", "Oxygen Sensor Replacement", "Serpentine Belt Replacement", "Shock and Strut Replacement", "Spark Plug Replacement", "Suspension Check", "Suspension Service", "Thermostat Replacement", "Tie Rod End Replacement", "Timing Belt Replacement", "Tire Rotation", "Transmission Flush", "Transmission Service", "Wheel Alignment", "Wheel Balancing", "Wheel Bearing Replacement", "Wheel Hub Assembly Replacement" });
            serviceCheckedListBox.Location = new Point(689, 47);
            serviceCheckedListBox.Margin = new Padding(2);
            serviceCheckedListBox.Name = "serviceCheckedListBox";
            serviceCheckedListBox.Size = new Size(211, 112);
            serviceCheckedListBox.TabIndex = 15;
            // 
            // notesTextBox
            // 
            notesTextBox.BackColor = Color.PeachPuff;
            notesTextBox.Location = new Point(689, 19);
            notesTextBox.Margin = new Padding(2);
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(211, 23);
            notesTextBox.TabIndex = 14;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.PeachPuff;
            costTextBox.Location = new Point(433, 178);
            costTextBox.Margin = new Padding(2);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(173, 23);
            costTextBox.TabIndex = 13;
            // 
            // odometerTextBox
            // 
            odometerTextBox.BackColor = Color.PeachPuff;
            odometerTextBox.Location = new Point(433, 152);
            odometerTextBox.Margin = new Padding(2);
            odometerTextBox.Name = "odometerTextBox";
            odometerTextBox.Size = new Size(173, 23);
            odometerTextBox.TabIndex = 12;
            // 
            // licensePlateTextBox
            // 
            licensePlateTextBox.BackColor = Color.PeachPuff;
            licensePlateTextBox.Location = new Point(433, 125);
            licensePlateTextBox.Margin = new Padding(2);
            licensePlateTextBox.Name = "licensePlateTextBox";
            licensePlateTextBox.Size = new Size(173, 23);
            licensePlateTextBox.TabIndex = 11;
            // 
            // vinTextBox
            // 
            vinTextBox.BackColor = Color.PeachPuff;
            vinTextBox.Location = new Point(433, 98);
            vinTextBox.Margin = new Padding(2);
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(173, 23);
            vinTextBox.TabIndex = 10;
            // 
            // colorTextBox
            // 
            colorTextBox.BackColor = Color.PeachPuff;
            colorTextBox.Location = new Point(433, 73);
            colorTextBox.Margin = new Padding(2);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(173, 23);
            colorTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.PeachPuff;
            yearTextBox.Location = new Point(433, 45);
            yearTextBox.Margin = new Padding(2);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(173, 23);
            yearTextBox.TabIndex = 8;
            // 
            // modelTextBox
            // 
            modelTextBox.BackColor = Color.PeachPuff;
            modelTextBox.Location = new Point(433, 18);
            modelTextBox.Margin = new Padding(2);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(173, 23);
            modelTextBox.TabIndex = 7;
            // 
            // makeTextBox
            // 
            makeTextBox.BackColor = Color.PeachPuff;
            makeTextBox.Location = new Point(118, 179);
            makeTextBox.Margin = new Padding(2);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(211, 23);
            makeTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.PeachPuff;
            phoneNumberTextBox.Location = new Point(118, 125);
            phoneNumberTextBox.Margin = new Padding(2);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(211, 23);
            phoneNumberTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.PeachPuff;
            emailTextBox.Location = new Point(118, 98);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(211, 23);
            emailTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.PeachPuff;
            lastNameTextBox.Location = new Point(118, 72);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(211, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(635, 101);
            serviceLabel.Margin = new Padding(2, 0, 2, 0);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(47, 15);
            serviceLabel.TabIndex = 35;
            serviceLabel.Text = "Service:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(334, 180);
            costLabel.Margin = new Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(89, 15);
            costLabel.TabIndex = 33;
            costLabel.Text = "Estimated Cost:";
            // 
            // serviceDateLabel
            // 
            serviceDateLabel.AutoSize = true;
            serviceDateLabel.Location = new Point(606, 179);
            serviceDateLabel.Margin = new Padding(2, 0, 2, 0);
            serviceDateLabel.Name = "serviceDateLabel";
            serviceDateLabel.Size = new Size(74, 15);
            serviceDateLabel.TabIndex = 36;
            serviceDateLabel.Text = "Service Date:";
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new Point(360, 154);
            odometerLabel.Margin = new Padding(2, 0, 2, 0);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new Size(64, 15);
            odometerLabel.TabIndex = 32;
            odometerLabel.Text = "Odometer:";
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Location = new Point(348, 128);
            licensePlateLabel.Margin = new Padding(2, 0, 2, 0);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new Size(78, 15);
            licensePlateLabel.TabIndex = 31;
            licensePlateLabel.Text = "License Plate:";
            // 
            // createButton
            // 
            createButton.BackColor = Color.Green;
            createButton.Location = new Point(832, 221);
            createButton.Margin = new Padding(2);
            createButton.Name = "createButton";
            createButton.Size = new Size(86, 28);
            createButton.TabIndex = 14;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.LimeGreen;
            clearButton.Location = new Point(42, 221);
            clearButton.Margin = new Padding(2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 28);
            clearButton.TabIndex = 18;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // recordsListView
            // 
            recordsListView.BackColor = Color.PeachPuff;
            recordsListView.Location = new Point(133, 253);
            recordsListView.Margin = new Padding(2);
            recordsListView.Name = "recordsListView";
            recordsListView.Size = new Size(786, 154);
            recordsListView.TabIndex = 18;
            recordsListView.UseCompatibleStateImageBehavior = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Crimson;
            deleteButton.Location = new Point(342, 221);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 28);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DeepSkyBlue;
            updateButton.Location = new Point(133, 221);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(86, 28);
            updateButton.TabIndex = 20;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteCheckBox
            // 
            deleteCheckBox.Location = new Point(0, 0);
            deleteCheckBox.Margin = new Padding(2);
            deleteCheckBox.Name = "deleteCheckBox";
            deleteCheckBox.Size = new Size(73, 14);
            deleteCheckBox.TabIndex = 0;
            // 
            // MaintenanceRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(926, 415);
            Controls.Add(deleteCheckBox);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(recordsListView);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Controls.Add(recordsListBox);
            Controls.Add(recordsGroupBox);
            Margin = new Padding(2);
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
        private Button deleteButton;
        private Button updateButton;
        private CheckBox deleteCheckBox;
    }
}