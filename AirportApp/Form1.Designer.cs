namespace AirportApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txt_Passenger_Name = new TextBox();
            label2 = new Label();
            cbox_Airport = new ComboBox();
            btn_Booking = new Button();
            grpAirport = new GroupBox();
            txt_Add_Airport = new TextBox();
            btn_Add_Airport = new Button();
            txt_ViewBooking = new TextBox();
            btn_Booking_Details = new Button();
            btn_Delete = new Button();
            label3 = new Label();
            cboAllAirport = new ComboBox();
            txt_Password = new TextBox();
            btn_Admin = new Button();
            grpBox_Class = new GroupBox();
            rdo_btn_EconomyClass = new RadioButton();
            rdo_btn_BusinessClass = new RadioButton();
            rdo_btn_FirstClass = new RadioButton();
            chck_Bx_Return = new CheckBox();
            label4 = new Label();
            cbo_Desintation = new ComboBox();
            label5 = new Label();
            cbo_Onward_Desintation = new ComboBox();
            tabMain = new TabControl();
            tbPg_BookingFlight = new TabPage();
            tbPg_Admin = new TabPage();
            btn_Logout = new Button();
            btn_Help = new Button();
            grpAirport.SuspendLayout();
            grpBox_Class.SuspendLayout();
            tabMain.SuspendLayout();
            tbPg_BookingFlight.SuspendLayout();
            tbPg_Admin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Passenger Full Name";
            // 
            // txt_Passenger_Name
            // 
            txt_Passenger_Name.Location = new Point(183, 14);
            txt_Passenger_Name.Margin = new Padding(3, 2, 3, 2);
            txt_Passenger_Name.Name = "txt_Passenger_Name";
            txt_Passenger_Name.PlaceholderText = "E.g. Jane H Doe";
            txt_Passenger_Name.Size = new Size(303, 23);
            txt_Passenger_Name.TabIndex = 5;
            txt_Passenger_Name.TextChanged += txt_Passenger_Name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 52);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Depature Airport";
            label2.Click += label2_Click;
            // 
            // cbox_Airport
            // 
            cbox_Airport.FormattingEnabled = true;
            cbox_Airport.ItemHeight = 15;
            cbox_Airport.Items.AddRange(new object[] { "London", "Dublin", "Dubai" });
            cbox_Airport.Location = new Point(183, 47);
            cbox_Airport.Margin = new Padding(3, 2, 3, 2);
            cbox_Airport.Name = "cbox_Airport";
            cbox_Airport.Size = new Size(303, 23);
            cbox_Airport.TabIndex = 6;
            // 
            // btn_Booking
            // 
            btn_Booking.BackColor = Color.White;
            btn_Booking.Location = new Point(349, 259);
            btn_Booking.Margin = new Padding(3, 2, 3, 2);
            btn_Booking.Name = "btn_Booking";
            btn_Booking.Size = new Size(137, 31);
            btn_Booking.TabIndex = 13;
            btn_Booking.Text = "&Book Flight";
            btn_Booking.UseVisualStyleBackColor = false;
            btn_Booking.Click += btn_Booking_Click;
            // 
            // grpAirport
            // 
            grpAirport.BackColor = Color.White;
            grpAirport.Controls.Add(txt_Add_Airport);
            grpAirport.Controls.Add(btn_Add_Airport);
            grpAirport.Controls.Add(txt_ViewBooking);
            grpAirport.Controls.Add(btn_Booking_Details);
            grpAirport.Controls.Add(btn_Delete);
            grpAirport.Controls.Add(label3);
            grpAirport.Controls.Add(cboAllAirport);
            grpAirport.Enabled = false;
            grpAirport.Location = new Point(15, 23);
            grpAirport.Margin = new Padding(3, 2, 3, 2);
            grpAirport.Name = "grpAirport";
            grpAirport.Padding = new Padding(3, 2, 3, 2);
            grpAirport.Size = new Size(755, 202);
            grpAirport.TabIndex = 6;
            grpAirport.TabStop = false;
            grpAirport.Text = "Airports";
            // 
            // txt_Add_Airport
            // 
            txt_Add_Airport.Location = new Point(6, 122);
            txt_Add_Airport.Margin = new Padding(3, 2, 3, 2);
            txt_Add_Airport.Name = "txt_Add_Airport";
            txt_Add_Airport.Size = new Size(210, 23);
            txt_Add_Airport.TabIndex = 17;
            // 
            // btn_Add_Airport
            // 
            btn_Add_Airport.BackColor = Color.LightCyan;
            btn_Add_Airport.Location = new Point(124, 149);
            btn_Add_Airport.Margin = new Padding(3, 2, 3, 2);
            btn_Add_Airport.Name = "btn_Add_Airport";
            btn_Add_Airport.Size = new Size(92, 22);
            btn_Add_Airport.TabIndex = 18;
            btn_Add_Airport.Text = "&Add";
            btn_Add_Airport.UseVisualStyleBackColor = false;
            btn_Add_Airport.Click += btn_Add_Airport_Click;
            // 
            // txt_ViewBooking
            // 
            txt_ViewBooking.Location = new Point(289, 27);
            txt_ViewBooking.Margin = new Padding(3, 2, 3, 2);
            txt_ViewBooking.Multiline = true;
            txt_ViewBooking.Name = "txt_ViewBooking";
            txt_ViewBooking.ReadOnly = true;
            txt_ViewBooking.Size = new Size(429, 118);
            txt_ViewBooking.TabIndex = 19;
            // 
            // btn_Booking_Details
            // 
            btn_Booking_Details.BackColor = Color.LightCyan;
            btn_Booking_Details.Location = new Point(419, 161);
            btn_Booking_Details.Margin = new Padding(3, 2, 3, 2);
            btn_Booking_Details.Name = "btn_Booking_Details";
            btn_Booking_Details.Size = new Size(156, 22);
            btn_Booking_Details.TabIndex = 20;
            btn_Booking_Details.Text = "&Booking Details";
            btn_Booking_Details.UseVisualStyleBackColor = false;
            btn_Booking_Details.Click += btn_Booking_Details_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.LightCyan;
            btn_Delete.Location = new Point(123, 76);
            btn_Delete.Margin = new Padding(3, 2, 3, 2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(92, 22);
            btn_Delete.TabIndex = 16;
            btn_Delete.Text = "&Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 29);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "All Airports";
            // 
            // cboAllAirport
            // 
            cboAllAirport.FormattingEnabled = true;
            cboAllAirport.Location = new Point(6, 49);
            cboAllAirport.Margin = new Padding(3, 2, 3, 2);
            cboAllAirport.Name = "cboAllAirport";
            cboAllAirport.Size = new Size(210, 23);
            cboAllAirport.TabIndex = 15;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(6, 205);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.PlaceholderText = "Enter admin password";
            txt_Password.Size = new Size(135, 23);
            txt_Password.TabIndex = 1;
            // 
            // btn_Admin
            // 
            btn_Admin.BackColor = Color.LightCyan;
            btn_Admin.Location = new Point(138, 205);
            btn_Admin.Margin = new Padding(3, 2, 3, 2);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(91, 23);
            btn_Admin.TabIndex = 2;
            btn_Admin.Text = "&Admin";
            btn_Admin.UseVisualStyleBackColor = false;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // grpBox_Class
            // 
            grpBox_Class.BackColor = Color.Azure;
            grpBox_Class.Controls.Add(rdo_btn_EconomyClass);
            grpBox_Class.Controls.Add(rdo_btn_BusinessClass);
            grpBox_Class.Controls.Add(rdo_btn_FirstClass);
            grpBox_Class.Location = new Point(18, 179);
            grpBox_Class.Margin = new Padding(3, 2, 3, 2);
            grpBox_Class.Name = "grpBox_Class";
            grpBox_Class.Padding = new Padding(3, 2, 3, 2);
            grpBox_Class.Size = new Size(148, 112);
            grpBox_Class.TabIndex = 7;
            grpBox_Class.TabStop = false;
            grpBox_Class.Text = "Seat Type";
            // 
            // rdo_btn_EconomyClass
            // 
            rdo_btn_EconomyClass.AutoSize = true;
            rdo_btn_EconomyClass.Location = new Point(5, 76);
            rdo_btn_EconomyClass.Margin = new Padding(3, 2, 3, 2);
            rdo_btn_EconomyClass.Name = "rdo_btn_EconomyClass";
            rdo_btn_EconomyClass.Size = new Size(105, 19);
            rdo_btn_EconomyClass.TabIndex = 12;
            rdo_btn_EconomyClass.TabStop = true;
            rdo_btn_EconomyClass.Text = "Economy Class";
            rdo_btn_EconomyClass.UseVisualStyleBackColor = true;
            // 
            // rdo_btn_BusinessClass
            // 
            rdo_btn_BusinessClass.AutoSize = true;
            rdo_btn_BusinessClass.Location = new Point(6, 53);
            rdo_btn_BusinessClass.Margin = new Padding(3, 2, 3, 2);
            rdo_btn_BusinessClass.Name = "rdo_btn_BusinessClass";
            rdo_btn_BusinessClass.Size = new Size(100, 19);
            rdo_btn_BusinessClass.TabIndex = 11;
            rdo_btn_BusinessClass.TabStop = true;
            rdo_btn_BusinessClass.Text = "Business Class";
            rdo_btn_BusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdo_btn_FirstClass
            // 
            rdo_btn_FirstClass.AutoSize = true;
            rdo_btn_FirstClass.Location = new Point(6, 30);
            rdo_btn_FirstClass.Margin = new Padding(3, 2, 3, 2);
            rdo_btn_FirstClass.Name = "rdo_btn_FirstClass";
            rdo_btn_FirstClass.Size = new Size(77, 19);
            rdo_btn_FirstClass.TabIndex = 10;
            rdo_btn_FirstClass.TabStop = true;
            rdo_btn_FirstClass.Text = "First Class";
            rdo_btn_FirstClass.UseVisualStyleBackColor = true;
            // 
            // chck_Bx_Return
            // 
            chck_Bx_Return.AutoSize = true;
            chck_Bx_Return.Location = new Point(183, 156);
            chck_Bx_Return.Margin = new Padding(3, 2, 3, 2);
            chck_Bx_Return.Name = "chck_Bx_Return";
            chck_Bx_Return.Size = new Size(94, 19);
            chck_Bx_Return.TabIndex = 9;
            chck_Bx_Return.Text = "Return Flight";
            chck_Bx_Return.UseVisualStyleBackColor = true;
            chck_Bx_Return.CheckedChanged += chck_Bx_Return_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 84);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 12;
            label4.Text = "Destination Airport";
            // 
            // cbo_Desintation
            // 
            cbo_Desintation.FormattingEnabled = true;
            cbo_Desintation.ItemHeight = 15;
            cbo_Desintation.Location = new Point(183, 84);
            cbo_Desintation.Margin = new Padding(3, 2, 3, 2);
            cbo_Desintation.Name = "cbo_Desintation";
            cbo_Desintation.Size = new Size(303, 23);
            cbo_Desintation.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 123);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 14;
            label5.Text = "Onward Desitnation";
            // 
            // cbo_Onward_Desintation
            // 
            cbo_Onward_Desintation.FormattingEnabled = true;
            cbo_Onward_Desintation.ItemHeight = 15;
            cbo_Onward_Desintation.Location = new Point(183, 120);
            cbo_Onward_Desintation.Margin = new Padding(3, 2, 3, 2);
            cbo_Onward_Desintation.Name = "cbo_Onward_Desintation";
            cbo_Onward_Desintation.Size = new Size(303, 23);
            cbo_Onward_Desintation.TabIndex = 8;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tbPg_BookingFlight);
            tabMain.Controls.Add(tbPg_Admin);
            tabMain.Location = new Point(235, 6);
            tabMain.Margin = new Padding(3, 2, 3, 2);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(810, 322);
            tabMain.TabIndex = 14;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // tbPg_BookingFlight
            // 
            tbPg_BookingFlight.BackColor = Color.Azure;
            tbPg_BookingFlight.Controls.Add(label1);
            tbPg_BookingFlight.Controls.Add(cbo_Onward_Desintation);
            tbPg_BookingFlight.Controls.Add(txt_Passenger_Name);
            tbPg_BookingFlight.Controls.Add(label5);
            tbPg_BookingFlight.Controls.Add(label2);
            tbPg_BookingFlight.Controls.Add(cbo_Desintation);
            tbPg_BookingFlight.Controls.Add(cbox_Airport);
            tbPg_BookingFlight.Controls.Add(label4);
            tbPg_BookingFlight.Controls.Add(btn_Booking);
            tbPg_BookingFlight.Controls.Add(chck_Bx_Return);
            tbPg_BookingFlight.Controls.Add(grpBox_Class);
            tbPg_BookingFlight.Location = new Point(4, 24);
            tbPg_BookingFlight.Margin = new Padding(3, 2, 3, 2);
            tbPg_BookingFlight.Name = "tbPg_BookingFlight";
            tbPg_BookingFlight.Padding = new Padding(3, 2, 3, 2);
            tbPg_BookingFlight.Size = new Size(802, 294);
            tbPg_BookingFlight.TabIndex = 0;
            tbPg_BookingFlight.Text = "Booking Flight";
            // 
            // tbPg_Admin
            // 
            tbPg_Admin.BackColor = Color.Azure;
            tbPg_Admin.Controls.Add(btn_Logout);
            tbPg_Admin.Controls.Add(grpAirport);
            tbPg_Admin.Location = new Point(4, 24);
            tbPg_Admin.Margin = new Padding(3, 2, 3, 2);
            tbPg_Admin.Name = "tbPg_Admin";
            tbPg_Admin.Padding = new Padding(3, 2, 3, 2);
            tbPg_Admin.Size = new Size(802, 294);
            tbPg_Admin.TabIndex = 1;
            tbPg_Admin.Text = "Admin";
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(705, 255);
            btn_Logout.Margin = new Padding(3, 2, 3, 2);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(82, 29);
            btn_Logout.TabIndex = 21;
            btn_Logout.Text = "&Logout";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Help
            // 
            btn_Help.BackColor = Color.LightCyan;
            btn_Help.Location = new Point(148, 299);
            btn_Help.Name = "btn_Help";
            btn_Help.Size = new Size(81, 25);
            btn_Help.TabIndex = 3;
            btn_Help.Text = "&Help";
            btn_Help.UseVisualStyleBackColor = false;
            btn_Help.Click += btn_Help_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1052, 340);
            Controls.Add(btn_Help);
            Controls.Add(tabMain);
            Controls.Add(txt_Password);
            Controls.Add(btn_Admin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Flight Booking System";
            Load += Form1_Load;
            grpAirport.ResumeLayout(false);
            grpAirport.PerformLayout();
            grpBox_Class.ResumeLayout(false);
            grpBox_Class.PerformLayout();
            tabMain.ResumeLayout(false);
            tbPg_BookingFlight.ResumeLayout(false);
            tbPg_BookingFlight.PerformLayout();
            tbPg_Admin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Passenger_Name;
        private Label label2;
        private ComboBox cbox_Airport;
        private Button btn_Booking;
        private GroupBox grpAirport;
        private Label label3;
        private ComboBox cboAllAirport;
        private Button btn_Delete;
        private Button btn_Add_Airport;
        private TextBox txt_Add_Airport;
        private GroupBox grpBox_Class;
        private RadioButton rdo_btn_EconomyClass;
        private RadioButton rdo_btn_BusinessClass;
        private RadioButton rdo_btn_FirstClass;
        private TextBox txt_Password;
        private Button btn_Admin;
        private CheckBox chck_Bx_Return;
        private TextBox txt_ViewBooking;
        private Button btn_Booking_Details;
        private Label label4;
        private ComboBox cbo_Desintation;
        private Label label5;
        private ComboBox cbo_Onward_Desintation;
        private TabControl tabMain;
        private TabPage tbPg_BookingFlight;
        private TabPage tbPg_Admin;
        private Button btn_Logout;
        private Button btn_Help;
    }
}
