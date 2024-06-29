using System.Diagnostics;

namespace AirportApp
{
    public partial class Form1 : Form
    {
        //path of files stored
        const string Airport_File = @"C:\Users\Yashashwini\Desktop\Airports.txt";
        const string Passenger_File = @"C:\Users\Yashashwini\Desktop\Passenger.csv";
        const string Help_File = @"C:\Users\Yashashwini\Desktop\Flight Help.pdf";


        //create a new list of type string
        List<string> Airports = new List<string>();
        // this is a bridge from List and CboBoxes
        BindingSource binding1 = new BindingSource();
        BindingSource binding2 = new BindingSource();
        BindingSource binding3 = new BindingSource();
        BindingSource binding4 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //method to diplay the booking details and on confirmation write to passenger file
        private void btn_Booking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking(txt_Passenger_Name.Text, cbox_Airport.Text, cbo_Desintation.Text, cbo_Onward_Desintation.Text);
            if (rdo_btn_FirstClass.Checked == true)
            {
                booking.Seat_Type = " First Class";

            }
            else if (rdo_btn_BusinessClass.Checked == true)
            {
                booking.Seat_Type = " Business Class";
            }
            else
            {
                booking.Seat_Type = " Economy Class";
            }

            if (chck_Bx_Return.Checked)
            {
                booking.Return_Flight = true;
            }
            else
            {
                booking.Return_Flight = false;
            }

            if (txt_Passenger_Name.Text != "" && cbox_Airport.Text != cbo_Desintation.Text)
            {
                string booking_Detail = $"Passenger Name: {booking.Passenger_Name}\n" +
                                    $"Booking ID: {booking.Booking_Id}\n" +
                                    $"Departure Airport: {booking.Departure_Airport}\n" +
                                    $"Destination Airport: {booking.Destination_Airport}\n\n" +
                                    $"Save details to file";
                DialogResult resuult = MessageBox.Show(booking_Detail, "New booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resuult == DialogResult.Yes)
                {
                    if (WritePassengerDetails(booking))
                    {
                        booking.WritebookingIDtoFile();
                    }

                    txt_Passenger_Name.Clear();
                }
                else
                {
                    MessageBox.Show("Details not saved");
                }
            }
            else
            {
                if (txt_Passenger_Name.Text == "")
                {
                    MessageBox.Show("Please enter the Passenger Full Name before booking");
                }
                else
                {
                    MessageBox.Show("Departure and Destination airports cannot be the same. Please reselect");
                }
            }


        }

        //method to read the data from the airport file 
        private void ReadAirportfromFile()
        {
            Airports = File.ReadAllLines(Airport_File).ToList<string>();
        }

        private void txt_Passenger_Name_TextChanged(object sender, EventArgs e)
        {

        }

        //Initally to set all the values when the from loads
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadAirportfromFile();
            Airports.Sort();
            binding1.DataSource = Airports;
            binding2.DataSource = Airports;
            binding3.DataSource = Airports;
            binding4.DataSource = Airports;
            cbox_Airport.DataSource = binding1;
            cboAllAirport.DataSource = binding2;
            cbo_Desintation.DataSource = binding3;
            cbo_Onward_Desintation.DataSource = binding4;
            rdo_btn_EconomyClass.Checked = true;
            tabMain.TabPages.Remove(tbPg_Admin);


        }

        //method to write to booking detailes passenger file

        private bool WritePassengerDetails(Booking booking)
        {
            string dataline = "";
            bool isSuccess = false;
            string header = "Passenger Name, Booking ID, Departure Airport,Destination Airport,Onward Destination, Seat Type, Return Flight";  // Your header
            try
            {
                if (!File.Exists(Passenger_File))
                {
                    File.WriteAllText(Passenger_File, header + Environment.NewLine);

                }
                dataline = $"{booking.Passenger_Name},{booking.Booking_Id},{booking.Departure_Airport},{booking.Destination_Airport},{booking.Onward_Destination},{booking.Seat_Type},{booking.Return_Flight}\n";
                File.AppendAllText(Passenger_File, dataline);
                MessageBox.Show("Booking details added to the file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;


        }
        //method to delete the existing airport from the list
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            string selected_Airport = cboAllAirport.Text;
            DialogResult resuult = MessageBox.Show($"Do you want delete: {selected_Airport}", "Delete Airport", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resuult == DialogResult.Yes)
            {
                Airports.Remove(selected_Airport);
                UpdateAirportList();
                WriteToAirportFile();
            }
            else
            {
                MessageBox.Show("Airport not deleted");
            }


        }
        //method to add new airport
        private void btn_Add_Airport_Click(object sender, EventArgs e)
        {
            Airports.Add(txt_Add_Airport.Text);
            MessageBox.Show($"Sucessfully added airport: {txt_Add_Airport.Text}");
            UpdateAirportList();
            WriteToAirportFile();

            txt_Add_Airport.Clear();

        }

        //method to bind all combo box with update airport information
        private void UpdateAirportList()
        {
            Airports.Sort();
            binding1.ResetBindings(false);
            binding2.ResetBindings(false);
            binding3.ResetBindings(false);
            binding4.ResetBindings(false);
        }

        //method to write to Airport file
        private bool WriteToAirportFile()
        {
            bool isSuccess = false;
            try
            {
                File.WriteAllLines(Airport_File, Airports);

                isSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;

        }

        // method to call the getadminaccess
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            GetAdminAccess();

        }

        // method to check and get access to the admin tab
        private void GetAdminAccess()
        {
            if (txt_Password.Text == "1234")
            {


                tabMain.TabPages.Add(tbPg_Admin);
                tabMain.SelectedTab = tbPg_Admin;
                grpAirport.Enabled = true;
                MessageBox.Show("Admin Tab is now available", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please enter the correct password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpAirport.Enabled = false;
                tabMain.TabPages.Remove(tbPg_Admin);
            }
            txt_Password.Clear();
        }

        //method to display booking details from the passenger file
        private void btn_Booking_Details_Click(object sender, EventArgs e)
        {
            txt_ViewBooking.Clear();
            txt_ViewBooking.Text = File.ReadAllText(Passenger_File);

        }

        //method to logout from the admin tab
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            tabMain.TabPages.Remove(tbPg_Admin);
        }

        //method to set the onward destination same as the departure destination
        private void chck_Bx_Return_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_Bx_Return.Checked)
            {
                cbo_Onward_Desintation.Text = cbox_Airport.Text;
                cbo_Onward_Desintation.Enabled = false;

            }
            else
            {
                cbo_Onward_Desintation.Enabled = true;
                cbo_Onward_Desintation.Text = "";


            }
        }

        //Method for viewing the PDF help file
        private void btn_Help_Click(object sender, EventArgs e)
        {
            ProcessStartInfo view_Help_PDF_Info = new ProcessStartInfo();
            view_Help_PDF_Info.FileName = Help_File;
            view_Help_PDF_Info.UseShellExecute = true;
            Process.Start(view_Help_PDF_Info);

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
