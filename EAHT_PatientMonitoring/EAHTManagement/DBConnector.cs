using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHTManagement
{
    class DBConnector
    {
        /* 
         * ATTRIBUTES
         */
        // one instance of the class DBConnector
        private static DBConnector _instance;

        // the variable that stores the connection string defined in the Project's properties
        private static string dBConnectionString;

        private SqlConnection sqlconn;

        private SqlDataAdapter sqlAdapter;

        /*
         * PROPERTIES
         */
        // property for the instance of the class DBConnector
        // create a UNIQUE object
        // (SINGLETON DESIGN PATTERN)
        public static DBConnector Instance
        {
            get
            {
                // check if the object was created
                if (_instance == null)
                {
                    //create the object
                    _instance = new DBConnector();

                    // set the connection string
                    DBConnector.DBConnectionString = Properties.Settings.Default.DBConnStr;

                }
                return _instance;
            }

        }

        //property for the connection string
        // to be used JUST in this class
        public static string DBConnectionString
        {
            set
            {
                dBConnectionString = value;
            }
        }


        /*
         * METHODS
         */
        //open the connection to the DB
        public void openConnection()
        {
            //create the connection
            sqlconn = new SqlConnection(dBConnectionString);

            //open the connection

            sqlconn.Open();
        }

        //close the connection to the DB
        public void closeConnection()
        {
            //close the connection
            sqlconn.Close();
        }

        // create and return a data set
        public DataSet getDataSet(string sqlStatement)
        {
            DataSet dsStaff = new DataSet();
            //open conn
            openConnection();

            //create the table adapter using the connection string and the sql statement
            sqlAdapter = new SqlDataAdapter(sqlStatement, dBConnectionString);

            //fills in the data set
            sqlAdapter.Fill(dsStaff);

            //close conn
            closeConnection();
            return dsStaff;

        }

        public void recordInDB(string name, string surname, string gender, string staffid, string password, 
                               string staffrole, string dob, string employmentdate, string email, string phone)            
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its properties
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.Insert; //set the sql query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("Gender", gender));
            command.Parameters.Add(new SqlParameter("StaffID", staffid));
            command.Parameters.Add(new SqlParameter("StaffPassword", password));
            command.Parameters.Add(new SqlParameter("StaffRole", staffrole));
            command.Parameters.Add(new SqlParameter("StaffDOB", dob));
            command.Parameters.Add(new SqlParameter("EmploymentDate", employmentdate));
            command.Parameters.Add(new SqlParameter("Email", email));
            command.Parameters.Add(new SqlParameter("Phone", phone));

            openConnection();
            command.Connection = sqlconn;

            //execute the command
            int noRows = command.ExecuteNonQuery();

            closeConnection();

        }



        public void SearchRec(string searchby)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its properties
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.Insert; //set the sql query
           
           
            command.Parameters.Add(new SqlParameter("Surname", searchby));

            openConnection();
            command.Connection = sqlconn;

            //execute the command
            int noRows = command.ExecuteNonQuery();

            closeConnection();

        }
    }
}
