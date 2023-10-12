//Author: Josh Werlein
//Purpose: Create an application that tracks maintenance to vehicles by owner
//Date: 10/08/2023

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MaintenanceRecords
{
    public partial class MaintenanceRecordsForm : Form
    {
        public MaintenanceRecordsForm()
        {
            InitializeComponent();
        }

        // Create a selectedRecordObject to reference which Record is selected 
        private Records selectedRecordsObject = new Records();

        // Create a BindingList of Records
        private BindingList<Records> recordsList = new BindingList<Records>();

        // Class level Object 
        private MaintenanceRecords.Records recordsObject = new MaintenanceRecords.Records();

        // Declare class level variables
        private decimal costDecimalCheck;
        private decimal serviceMultiplier;
        private int recordsOwnerIDLastNumber = 0;

        // Service multipliers
        private List<decimal> serviceList = new List<decimal>
        {
            1.2m, 1.3m, 1.4m, 1.5m, 1.6m,
            1.7m, 1.8m, 1.9m, 2.1m, 2.2m,
            2.3m, 2.4m, 2.5m, 2.6m, 2.7m,
            2.8m, 2.9m, 3.1m, 3.2m, 3.3m,
            3.4m, 3.5m, 3.6m, 3.7m, 3.8m,
            3.9m, 4.1m, 4.2m, 4.3m, 4.4m, 4.5m
        };

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int odometerIntCheck;
            int yearIntCheck;
            DateTime registrationDateTime;
            DateTime serviceDateTime;

            // Declare new Records Object
            var recordsObject = new Records();

            // Validate all input
            if (string.IsNullOrEmpty(this.firstNameTextBox.Text) || !this.firstNameTextBox.Text.All(char.IsLetter))
            {
                Msg("First name must be filled in with letters.");
                this.firstNameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(this.lastNameTextBox.Text) || !this.lastNameTextBox.Text.All(char.IsLetter))
            {
                Msg("Last name must be filled in with letters.");
                this.lastNameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                Msg("Email cannot be blank.");
                emailTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                Msg("Phone number cannot be blank.");
                phoneNumberTextBox.Focus();
                return;
            }
            else if (!DateTime.TryParse(registrationDateTimePicker.Text, out registrationDateTime))
            {
                Msg("Please enter a valid date.");
                registrationDateTimePicker.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(makeTextBox.Text) || !this.makeTextBox.Text.All(char.IsLetter))
            {
                Msg("Make must be filled in with letters.");
                makeTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(modelTextBox.Text))
            {
                Msg("Model cannot be blank.");
                modelTextBox.Focus();
                return;
            }
            else if (int.TryParse(yearTextBox.Text, out yearIntCheck) == false)
            {
                Msg("Year must be an integer.");
                yearTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(colorTextBox.Text) || !this.colorTextBox.Text.All(char.IsLetter))
            {
                Msg("Color must be filled in with letters.");
                colorTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(vinTextBox.Text))
            {
                Msg("Vin cannot be blank.");
                vinTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(licensePlateTextBox.Text))
            {
                Msg("License Plate cannot be blank.");
                licensePlateTextBox.Focus();
                return;
            }
            else if (int.TryParse(odometerTextBox.Text, out odometerIntCheck) == false)
            {
                Msg("Odometer must be an integer.");
                odometerTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(costTextBox.Text, out costDecimalCheck) == false)
            {
                Msg("Cost must be a decimal value.");
                costTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(notesTextBox.Text))
            {
                Msg("Notes can not be blank.");
                notesTextBox.Focus();
                return;
            }
            // Check if Service is selected
            else if (serviceCheckedListBox.SelectedIndex == -1)
            {
                Msg("Service must be selected.");
                this.serviceCheckedListBox.Focus();
                return;
            }
            else if (!DateTime.TryParse(serviceDateTimePicker.Text, out serviceDateTime))
            {
                Msg("Please enter a valid date.");
                serviceDateTimePicker.Focus();
                return;
            }
            // Update OwnerID and assign Owner information
            else
            {
                if (ownerIDTextBox.Text == String.Empty)
                {
                    recordsOwnerIDLastNumber++;
                    recordsObject.OwnerID = recordsOwnerIDLastNumber;
                }
                else
                {
                    recordsObject.OwnerID = int.Parse(ownerIDTextBox.Text);
                }
            }
            // Concatenate selected services into a comma separated string
            string selectedServices = string.Join(", ", serviceCheckedListBox.CheckedItems.Cast<string>());

            recordsObject.FirstName = firstNameTextBox.Text;
            recordsObject.LastName = lastNameTextBox.Text;
            recordsObject.Email = emailTextBox.Text;
            recordsObject.PhoneNumber = phoneNumberTextBox.Text;
            recordsObject.RegistrationDate = registrationDateTime;
            recordsObject.Make = makeTextBox.Text;
            recordsObject.Model = modelTextBox.Text;
            recordsObject.Year = yearIntCheck;
            recordsObject.Color = colorTextBox.Text;
            recordsObject.Vin = vinTextBox.Text;
            recordsObject.LicensePlate = licensePlateTextBox.Text;
            recordsObject.Odometer = odometerIntCheck;
            recordsObject.Cost = CalculateCost();
            recordsObject.Notes = notesTextBox.Text;
            recordsObject.Service = selectedServices;
            recordsObject.ServiceDate = serviceDateTime;

            // Set object's to selectedRecordsObject for the binding list
            selectedRecordsObject = recordsObject;
            recordsList.Add(recordsObject);
            recordsListBox.SelectedItem = recordsObject;

            // Set costLabel to "Total Cost:"
            costLabel.Text = "        Total Cost:";

            InsertRecords();
            DisplayRecords();
            PopulateListView();
        }

        private SqlConnection OpenDBConnection()
        {
            // Full path to bin/debug folder.
            string path = Application.StartupPath;
            int pathLength = path.Length;

            // Strip off the bin/debug folder to point  to the project folder
            path = path.Substring(0, pathLength - 25);

            // Create a connection string
            string connection = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + path + "MaintenanceRecords.mdf";

            // Create a connection Object to the database
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            // Open Database
            dbConnection.Open();

            return dbConnection;
        }

        private void ReloadRecords()
        {
            // Clear the Listbox
            recordsListBox.ClearSelected();

            // Open Database
            var connection = OpenDBConnection();

            // Create a Command Object
            var selectRecordsCommand = new SqlCommand("Select * from Records_Tbl;", connection);

            // Execute a Command into a DataReader
            var recordsReader = selectRecordsCommand.ExecuteReader();
            if (recordsReader.HasRows)
            {
                while (recordsReader.Read())
                {
                    var storedRecordsObject = new MaintenanceRecords.Records((int)recordsReader["OwnerID"]);
                    storedRecordsObject.FirstName = recordsReader["FirstName"].ToString();
                    storedRecordsObject.LastName = recordsReader["LastName"].ToString();
                    storedRecordsObject.Email = recordsReader["Email"].ToString();
                    storedRecordsObject.PhoneNumber = recordsReader["PhoneNumber"].ToString();
                    storedRecordsObject.RegistrationDate = DateTime.Parse(recordsReader["RegistrationDate"].ToString());
                    storedRecordsObject.Make = recordsReader["Make"].ToString();
                    storedRecordsObject.Model = recordsReader["Model"].ToString();
                    storedRecordsObject.Year = int.Parse(recordsReader["Year"].ToString());
                    storedRecordsObject.Color = recordsReader["Color"].ToString();
                    storedRecordsObject.Vin = recordsReader["Vin"].ToString();
                    storedRecordsObject.LicensePlate = recordsReader["LicensePlate"].ToString();
                    storedRecordsObject.Odometer = int.Parse(recordsReader["Odometer"].ToString());
                    storedRecordsObject.Cost = decimal.Parse(recordsReader["Cost"].ToString());
                    storedRecordsObject.Notes = recordsReader["Notes"].ToString();
                    storedRecordsObject.Service = recordsReader["Service"].ToString();
                    storedRecordsObject.ServiceDate = DateTime.Parse(recordsReader["ServiceDate"].ToString());

                    // Update UserID
                    if (storedRecordsObject.OwnerID > recordsOwnerIDLastNumber)
                    {
                        recordsOwnerIDLastNumber = storedRecordsObject.OwnerID;
                    }
                    // Add Owner to the ownerList
                    recordsList.Add(storedRecordsObject);
                    //Msg(recordsOwnerIDLastNumber.ToString());
                }
            }
            connection.Close();
            connection.Dispose();
        }

        private void InsertRecords()
        {
            // Open Database
            var connection = OpenDBConnection();

            // Create SQL String for each table
            string recordSQL = "INSERT INTO Records_Tbl (FirstName, LastName, Email, PhoneNumber, RegistrationDate, Make, Model, Year, Color, Vin, LicensePlate, Odometer, Cost, Notes, Service, ServiceDate) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @RegistrationDate, @Make, @Model, @Year, @Color, @Vin, @LicensePlate, @Odometer, @Cost, @Notes, @Service, @ServiceDate)";
            //Msg(recordSQL.ToString());

            // Create Command
            var insertRecordCommand = new SqlCommand(recordSQL, connection);

            // Populate Parameters of the Insert
            insertRecordCommand.Parameters.AddWithValue("@FirstName", recordsList.Last().FirstName);
            insertRecordCommand.Parameters.AddWithValue("@LastName", recordsList.Last().LastName);
            insertRecordCommand.Parameters.AddWithValue("@Email", recordsList.Last().Email);
            insertRecordCommand.Parameters.AddWithValue("@PhoneNumber", recordsList.Last().PhoneNumber);
            insertRecordCommand.Parameters.AddWithValue("@RegistrationDate", recordsList.Last().RegistrationDate);
            insertRecordCommand.Parameters.AddWithValue("@Make", recordsList.Last().Make);
            insertRecordCommand.Parameters.AddWithValue("@Model", recordsList.Last().Model);
            insertRecordCommand.Parameters.AddWithValue("@Year", recordsList.Last().Year);
            insertRecordCommand.Parameters.AddWithValue("@Color", recordsList.Last().Color);
            insertRecordCommand.Parameters.AddWithValue("@Vin", recordsList.Last().Vin);
            insertRecordCommand.Parameters.AddWithValue("@LicensePlate", recordsList.Last().LicensePlate);
            insertRecordCommand.Parameters.AddWithValue("@Odometer", recordsList.Last().Odometer);
            insertRecordCommand.Parameters.AddWithValue("@Cost", recordsList.Last().Cost);
            insertRecordCommand.Parameters.AddWithValue("@Notes", recordsList.Last().Notes);
            insertRecordCommand.Parameters.AddWithValue("@Service", recordsList.Last().Service);
            insertRecordCommand.Parameters.AddWithValue("@ServiceDate", recordsList.Last().ServiceDate);

            int intRowsAffected = insertRecordCommand.ExecuteNonQuery();

            if (intRowsAffected == 1)
            {
                Msg(recordsList.Last().FirstName + " was inserted.");
            }
            else
            {
                Msg("The insert failed.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ownerIDTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            makeTextBox.Text = string.Empty;
            modelTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            colorTextBox.Text = string.Empty;
            vinTextBox.Text = string.Empty;
            licensePlateTextBox.Text = string.Empty;
            odometerTextBox.Text = string.Empty;
            costTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            registrationDateTimePicker.Value = DateTime.Today;
            serviceDateTimePicker.Value = DateTime.Today;

            // Reset the label text to "Estimated Cost"
            costLabel.Text = "Estimated Cost:";

            // Hide the Update button
            updateButton.Visible = false;

            // Clear all selections in the serviceCheckedListBox
            for (int i = 0; i < serviceCheckedListBox.Items.Count; i++)
            {
                serviceCheckedListBox.SetItemChecked(i, false);
            }
        }

        // Method to set the selected services in the checked list box
        private void SetSelectedServices()
        {
            if (selectedRecordsObject != null)
            {
                serviceCheckedListBox.ClearSelected();
                string[] selectedServices = selectedRecordsObject.Service.Split(',');
                foreach (string service in selectedServices)
                {
                    int index = serviceCheckedListBox.Items.IndexOf(service);
                    if (index >= 0)
                    {
                        serviceCheckedListBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        // Method to calculate the cost based on selected services
        private decimal CalculateCost()
        {
            // Handle the case when no services are checked
            if (selectedRecordsObject == null)
            {
                return 0.00m;
            }
            else if (serviceCheckedListBox.CheckedItems.Count == 0)
            {
                // No services are selected, prompt the user to select a service
                Msg("Please select at least one service.");
                this.serviceCheckedListBox.Focus();
                return 0.00m;
            }
            else
            {
                decimal baseCost = 100;

                decimal totalCost = baseCost;
                //MessageBox.Show($"Base Cost: {baseCost}, Total Cost: {totalCost}");

                // Iterate through checked items and apply multipliers
                foreach (int index in serviceCheckedListBox.CheckedIndices)
                {
                    if (index >= 0 && index < serviceList.Count)
                    {
                        totalCost *= serviceList[index];
                    }
                }
                return totalCost;
            }
        }

        private void recordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedRecord();
            SetSelectedServices();
            if (recordsListBox.SelectedItem != null)
            {
                // Show the Update button
                updateButton.Visible = true;
                selectedRecordsObject = (Records)recordsListBox.SelectedItem;
                DisplayRecords();
            }
            else
            {
                selectedRecordsObject = null;
                DisplayRecords();
            }
        }

        private void ChangeSelectedRecord()
        {
            if (recordsListBox.SelectedItem is object)
            {
                selectedRecordsObject = (Records)recordsListBox.SelectedItem;
                DisplayRecords();
            }
            else
            {
                selectedRecordsObject = null;

                DisplayRecords();
            }
        }

        private void DisplayRecords()
        {
            // Populate Textboxes with the records
            ownerIDTextBox.Text = selectedRecordsObject.OwnerID.ToString();
            firstNameTextBox.Text = selectedRecordsObject.FirstName;
            lastNameTextBox.Text = selectedRecordsObject.LastName;
            emailTextBox.Text = selectedRecordsObject.Email;
            phoneNumberTextBox.Text = selectedRecordsObject.PhoneNumber;
            registrationDateTimePicker.Text = selectedRecordsObject.RegistrationDate.ToString();
            makeTextBox.Text = selectedRecordsObject.Make;
            modelTextBox.Text = selectedRecordsObject.Model;
            yearTextBox.Text = selectedRecordsObject.Year.ToString();
            colorTextBox.Text = selectedRecordsObject.Color;
            vinTextBox.Text = selectedRecordsObject.Vin;
            licensePlateTextBox.Text = selectedRecordsObject.LicensePlate;
            odometerTextBox.Text = selectedRecordsObject.Odometer.ToString();
            costTextBox.Text = selectedRecordsObject.Cost.ToString("C");
            notesTextBox.Text = selectedRecordsObject.Notes;
            serviceDateTimePicker.Text = selectedRecordsObject.ServiceDate.ToString();

            // Set costLabel to "Total Cost 
            costLabel.Text = "        Total Cost:";

            // Clear all selections in the checked list box
            for (int i = 0; i < serviceCheckedListBox.Items.Count; i++)
            {
                serviceCheckedListBox.SetItemChecked(i, false);
            }

            if (selectedRecordsObject != null)
            {
                // Split the services into an array 
                string[] selectedService = selectedRecordsObject.Service.Split(',');

                // Iterate through the items in the checked list box
                foreach (string services in selectedService)
                {
                    // Check if the service at index is in the selectedServices array
                    int index = serviceCheckedListBox.Items.IndexOf(services.Trim());
                    if (index >= 0)
                    {
                        // Set the item as checked
                        serviceCheckedListBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void MaintenanceRecordsForm_Load(object sender, EventArgs e)
        {
            // Set OwnerBinding List to Listbox
            recordsListBox.DataSource = recordsList;
            recordsListBox.DisplayMember = "FullName";

            // Load Owners from the database
            ReloadRecords();

            // Populate the ListView with the loaded records
            PopulateListView();

            // Initially hide the Update button
            updateButton.Visible = false;
        }

        private void serviceCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Method to handle all MessageBox's
        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Maintenace Records", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void PopulateListView()
        {
            // Clear existing items
            recordsListView.Items.Clear();
            recordsListView.Columns.Clear();

            recordsListView.View = View.Details;


            // Define the column headers and their widths
            recordsListView.Columns.Add("Owner ID", 90);
            recordsListView.Columns.Add("First Name", 100);
            recordsListView.Columns.Add("Last Name", 120);
            recordsListView.Columns.Add("Email", 180);
            recordsListView.Columns.Add("Phone Number", 140);
            recordsListView.Columns.Add("Registration Date", 150);
            recordsListView.Columns.Add("Make", 110);
            recordsListView.Columns.Add("Model", 90);
            recordsListView.Columns.Add("Year", 60);
            recordsListView.Columns.Add("Color", 90);
            recordsListView.Columns.Add("Vin Number", 140);
            recordsListView.Columns.Add("License Plate", 110);
            recordsListView.Columns.Add("Odometer", 100);
            recordsListView.Columns.Add("Total Cost", 90);
            recordsListView.Columns.Add("Notes", 250);
            recordsListView.Columns.Add("Service", 300);
            recordsListView.Columns.Add("Service Date", 150);


            foreach (var record in recordsList)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    record.OwnerID.ToString(),
                    record.FirstName,
                    record.LastName,
                    record.Email,
                    record.PhoneNumber,
                    record.RegistrationDate.ToString("yyyy-MM-dd"),
                    record.Make,
                    record.Model,
                    record.Year.ToString(),
                    record.Color,
                    record.Vin,
                    record.LicensePlate,
                    record.Odometer.ToString(),
                    record.Cost.ToString("C"),
                    record.Notes,
                    record.Service,
                    record.ServiceDate.ToString("yyyy-MM-dd")
                });
                recordsListView.Items.Add(item);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check if a Owner is selected
            if (selectedRecordsObject == null)
            {
                Msg("Please select a Owner to update.");
                return;
            }
            else
            {
                // Update the selected owner's information
                UpdateSelectedRecord();

                // Refresh the records and the list view
                ReloadRecords();
                PopulateListView();

                // Display a success message
                Msg("Owner information updated successfully.");
            }
        }
        private void UpdateSelectedRecord()
        {

        }
    }
}