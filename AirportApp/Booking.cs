using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp
{
    internal class Booking
    {

        //the properties of the booking class
        public string Passenger_Name { get; set; }
        private int _booking_Id;
        const string BookingID_File = @"C:\Users\Yashashwini\Desktop\Booking_ID.txt";
        public string Departure_Airport { get; set; }
        public string Destination_Airport { get; set; }
        public string Onward_Destination { get; set; }
        public string Seat_Type { get; set; }
        public bool Return_Flight { get; set; }
        public int Booking_Id
        { get
            {
                return _booking_Id;
            }
        }

        //private method for creating next booking ID 
        private int createBookingId()
        {
            int nextID = 0;
            try
            {
                string last_ID = File.ReadAllText(BookingID_File);
                nextID= Convert.ToInt32(last_ID)+1;

            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);  
            }
            return nextID;
        }
            
        // Constructor
        public Booking(string Passenger_Name, string Airport, string Destination_airport,string Onward_destination) 
        {

            this.Passenger_Name = Passenger_Name;
            this.Departure_Airport = Airport;
            this._booking_Id = createBookingId();
            this.Destination_Airport = Destination_airport;
            this.Onward_Destination = Onward_destination;
         



        }

        //method for writing the booking ID to the file
        public bool WritebookingIDtoFile()
        {
            bool result = false;
            try
            {
                File.WriteAllText(BookingID_File, _booking_Id.ToString());
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }



    }
}
