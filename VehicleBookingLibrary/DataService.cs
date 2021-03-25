using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace VehicleBookingLibrary
{
    public class DataService
    {
        private static DataService dataService;

        private static string databaseFile = @".\VehicleBookingSystemDB.db";
        public static bool DatabaseExists => File.Exists(databaseFile);


        private DataService()
        {
            if (! DatabaseExists)
            {
                SetupDatabase();
            }
        }

        /* Private Methods */

        private void SetupTables()
        {
            CreateCustomersTable();
            CreateVehiclesTable();
            CreateBookingsTable();
        }

        private void CreateCustomersTable()
        {
            string query = "create table if not exists customers" +
                "(id integer primary key autoincrement not null unique, " +
                "first_name text not null," +
                "last_name text not null," +
                "contact_number text not null);";

            this.WriteToDatabase(query);
        }

        private void CreateVehiclesTable()
        {
            string query = "create table if not exists vehicles" +
                "(id integer primary key autoincrement not null unique, " +
                "make text not null," +
                "model text not null," +
                "registration_number text not null);";

            this.WriteToDatabase(query);
        }

        private void CreateBookingsTable()
        {
            // limit on notes column taken from stackoverflow (reference #13, https://stackoverflow.com/a/17798404)
            string query = "create table if not exists bookings" +
                "(id integer primary key autoincrement not null unique," +
                "date text not null," +
                "start_time text not null," +
                "end_time text not null," +
                "customer_id int not null," +
                "vehicle_id int not null," +
                "notes text check (length(notes) <= 25) not null," +
                "constraint \"customer_id_constraint\" foreign key (customer_id) references customers (id)," +
                "constraint \"vehicle_id_constraint\" foreign key (vehicle_id) references vehicles (id))";

            this.WriteToDatabase(query);
        }

        private Vehicle ExtractVehicleFromRow(DataRow vehicleTableRow)
        {
            Vehicle vehicle;

            int id = int.Parse(vehicleTableRow["id"].ToString());
            string make = vehicleTableRow["make"].ToString();
            string model = vehicleTableRow["model"].ToString();
            string registrationNumber = vehicleTableRow["registration_number"].ToString();

            vehicle = new Vehicle { Id = id, Make = make, Model = model, RegistrationNumber = registrationNumber };

            return vehicle;

        }

        private Customer ExtractCustomerFromRow(DataRow customersTableRow)
        {
            Customer customer;

            int id = int.Parse(customersTableRow["id"].ToString());
            string firstName = customersTableRow["first_name"].ToString();
            string lastName = customersTableRow["last_name"].ToString();
            string contactNumber = customersTableRow["contact_number"].ToString();

            customer = new Customer { Id = id, FirstName = firstName, LastName = lastName, ContactNumber = contactNumber };

            return customer;
        }

        private Booking ExtractBookingFromRow(DataRow bookingsTableRow)
        {
            Booking booking;

            int id = int.Parse(bookingsTableRow["id"].ToString());

            string dateString = bookingsTableRow["date"].ToString();
            DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", null);

            string startTimeString = bookingsTableRow["start_time"].ToString();
            DateTime startTime = DateTime.ParseExact(startTimeString, "HH:mm", null);

            string endTimeString = bookingsTableRow["end_time"].ToString();
            DateTime endTime = DateTime.ParseExact(endTimeString, "HH:mm", null);

            int customerId = int.Parse(bookingsTableRow["customer_id"].ToString());
            int vehicleId = int.Parse(bookingsTableRow["vehicle_id"].ToString());
            string notes = bookingsTableRow["notes"].ToString();

            Customer customer = ExtractCustomerFromId(customerId);
            Vehicle vehicle = ExtractVehicleFromId(vehicleId);

            booking = new Booking()
            {
                Id = id,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                Customer = customer,
                Vehicle = vehicle,
                Notes = notes
            };

            return booking;
        }

        // Below taken from Tim Corey - Using SQLite (see reference #4)
        private string GetConnectingString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private DataTable RetrieveFromDatabase(string query,
            Dictionary<string, object> parameters = null)
        {
            DataTable dataTable;

            using (SQLiteConnection connection =
                new SQLiteConnection(this.GetConnectingString()))
            {
                connection.Open();

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameterKeyValuePair in parameters)
                    {
                        string parameterName = parameterKeyValuePair.Key;
                        object parameterValue = parameterKeyValuePair.Value;
                        dataAdapter.SelectCommand.Parameters.AddWithValue(parameterName, parameterValue);
                    }
                }

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void WriteToDatabase(string query,
            Dictionary<string, object> parameters = null)
        {
            using (SQLiteConnection connection =
                new SQLiteConnection(this.GetConnectingString()))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameterKeyValuePair in parameters)
                    {
                        string parameterName = parameterKeyValuePair.Key;
                        object parameterValue = parameterKeyValuePair.Value;
                        command.Parameters
                            .AddWithValue(parameterName, parameterValue);
                    }
                }

                command.ExecuteNonQuery();
            }
        }


        /* Public Methods */

        public void SetupDatabase()
        {
            if (!DatabaseExists)
            {
                SQLiteConnection.CreateFile(databaseFile);
                this.SetupTables();
            }
        }

        public static DataService GetDataService()
        {
            if (dataService is null)
            {
                dataService = new DataService();
            }

            return dataService;
        }

        public Customer ExtractCustomerFromId(int customerId)
        {
            string query = "select * from customers where id = @customer_id";
            Dictionary<string, object> parameterValuePairs =
                new Dictionary<string, object> { { "@customer_id", customerId } };

            DataTable customerTable = RetrieveFromDatabase(query, parameterValuePairs);

            DataRow customerTableRow = customerTable.Rows[0];
            int id = int.Parse(customerTableRow["id"].ToString());
            string firstName = customerTableRow["first_name"].ToString();
            string lastName = customerTableRow["last_name"].ToString();
            string contactNumber = customerTableRow["contact_number"].ToString();

            Customer customer = new Customer()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber
            };

            return customer;
        }

        public Vehicle ExtractVehicleFromId(int vehicleId)
        {
            string query = "select * from vehicles where id = @vehicle_id";
            Dictionary<string, object> parameterValuePairs =
                new Dictionary<string, object> { { "@vehicle_id", vehicleId } };

            DataTable vehicleTable = RetrieveFromDatabase(query, parameterValuePairs);

            DataRow vehicleTableRow = vehicleTable.Rows[0];
            int id = int.Parse(vehicleTableRow["id"].ToString());
            string make = vehicleTableRow["make"].ToString();
            string model = vehicleTableRow["model"].ToString();
            string registrationNumber = vehicleTableRow["registration_number"].ToString();

            Vehicle vehicle = new Vehicle()
            {
                Id = id,
                Make = make,
                Model = model,
                RegistrationNumber = registrationNumber
            };

            return vehicle;
        }

        public int GetNextCustomerId()
        {
            int nextId;

            string query = "select max(id) as max_id from customers;";

            DataTable customersTable = this.RetrieveFromDatabase(query);
            DataRow customersTableRow = customersTable.Rows[0];

            string maxIdValue = customersTableRow["max_id"].ToString();
            if (maxIdValue.Equals(""))
            {
                nextId = 1;
            }
            else
            {
                nextId = int.Parse(customersTableRow["max_id"].ToString()) + 1;
            }

            return nextId;
        }

        public int GetNextVehicleId()
        {
            int nextId;

            string query = "select max(id) as max_id from vehicles;";

            DataTable vehiclesTable = this.RetrieveFromDatabase(query);
            DataRow vehiclesTableRow = vehiclesTable.Rows[0];

            string maxIdValue = vehiclesTableRow["max_id"].ToString();
            if (maxIdValue.Equals(""))
            {
                nextId = 1;
            }
            else
            {
                nextId = int.Parse(vehiclesTableRow["max_id"].ToString()) + 1;
            }

            return nextId;
        }

        public List<Booking> GetBookingsAsList()
        {
            List<Booking> bookingList = new List<Booking>();

            string query = "select * from bookings;";

            DataTable bookingsTable = this.RetrieveFromDatabase(query);

            foreach (DataRow bookingRow in bookingsTable.Rows)
            {
                Booking booking = this.ExtractBookingFromRow(bookingRow);

                bookingList.Add(booking);
            }

            return bookingList;
        } 

        public List<Customer> GetCustomersAsList()
        {
            List<Customer> customerList = new List<Customer>();

            string query = "select * from customers;";

            DataTable customersTable = this.RetrieveFromDatabase(query);

            foreach (DataRow customerRow in customersTable.Rows)
            {
                Customer customer = this.ExtractCustomerFromRow(customerRow);

                customerList.Add(customer);
            }

            return customerList;

        }

        public List<Vehicle> GetVehiclesAsList()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            string query = "select * from vehicles;";

            DataTable vehiclesTable = this.RetrieveFromDatabase(query);

            foreach (DataRow vehicleRow in vehiclesTable.Rows)
            {
                Vehicle vehicle = this.ExtractVehicleFromRow(vehicleRow);

                vehicleList.Add(vehicle);
            }

            return vehicleList;
        }

        public Customer GetCustomerById(int id)
        {
            string query = "select * from customers where id = @id";

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object> { { "@id", id } };

            DataRow customerRow = this.RetrieveFromDatabase(query, parameterValuePairs).Rows[0];

            string firstName = customerRow["first_name"].ToString();
            string lastName = customerRow["last_name"].ToString();
            string contactNumber = customerRow["contact_number"].ToString();

            Customer customer = new Customer()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber
            };

            return customer;
        }
        
        public void SaveVehicle(Vehicle vehicle)
        {
            string query = "insert into vehicles (model, make, registration_number)" +
                "values (@model, @make, @registration_number);";

            string model = vehicle.Model;
            string make = vehicle.Make;
            string registrationNumber = vehicle.RegistrationNumber;

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object>
            {
                { "@model", model },
                { "@make", make },
                { "@registration_number", registrationNumber }
            };

            this.WriteToDatabase(query, parameterValuePairs);
        }

        public void SaveCustomer(Customer customer)
        {
            string query = "insert into customers (first_name, last_name, contact_number)" +
                "values (@first_name, @last_name, @contact_number);";

            string firstName = customer.FirstName;
            string lastName = customer.LastName;
            string contactNumber = customer.ContactNumber;

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object>
            {
                { "@first_name", firstName },
                { "@last_name", lastName },
                { "@contact_number", contactNumber }
            };

            this.WriteToDatabase(query, parameterValuePairs);
        }

        public void SaveBooking(Booking booking)
        {
            string query = "insert into bookings (date, start_time, end_time, notes, customer_id, vehicle_id) " +
                "values (@date, @start_time, @end_time, @notes, @customer_id, @vehicle_id);";

            string date = booking.Date.ToString("dd/MM/yyyy");
            string notes = booking.Notes;
            int customerId = booking.Customer.Id;
            int vehicleId = booking.Vehicle.Id;
            string startTime = booking.StartTime.ToString("HH:mm");
            string endTime = booking.EndTime.ToString("HH:mm");

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object>
            {
                { "@date", date },
                { "@start_time", startTime },
                { "@end_time", endTime },
                { "@notes", notes },
                { "@customer_id", customerId },
                { "@vehicle_id", vehicleId }
            };

            this.WriteToDatabase(query, parameterValuePairs);
        }

        public void UpdateCustomer(Customer customer)
        {
            string query = "update customers set " +
                "first_name = @first_name," +
                "last_name = @last_name," +
                "contact_number = @contact_number " +
                "where id = @id;";

            int id = customer.Id;
            string firstName = customer.FirstName;
            string lastName = customer.LastName;
            string contactNumber = customer.ContactNumber;

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object>
            {
                { "@id", id },
                { "@first_name", firstName },
                { "@last_name", lastName },
                { "@contact_number", contactNumber }
            };


            this.WriteToDatabase(query, parameterValuePairs);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            string query = "update vehicles set " +
                "model = @model," +
                "make = @make," +
                "registration_number = @registration_number " +
                "where id = @id;";

            int id = vehicle.Id;
            string model = vehicle.Model;
            string make = vehicle.Make;
            string registrationNumber = vehicle.RegistrationNumber;

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object>
            {
                { "@id", id },
                { "@model", model },
                { "@make", make },
                { "@registration_number", registrationNumber }
            };

            this.WriteToDatabase(query, parameterValuePairs);
        }

        public void DeleteBooking(int id)
        {
            string query = "delete from bookings where id = @id";

            Dictionary<string, object> parameterValuePairs = new Dictionary<string, object> { { "@id", id } };

            this.WriteToDatabase(query, parameterValuePairs);
        }

    }
}
