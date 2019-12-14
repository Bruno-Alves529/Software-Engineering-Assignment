using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
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
        public void OpenConnection()
        {
            //create the connection
            sqlconn = new SqlConnection(dBConnectionString);

            //open the connection

            sqlconn.Open();
        }

        //close the connection to the DB
        public void CloseConnection()
        {
            //close the connection
            sqlconn.Close();
        }

        // create and return a data set
        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dsStaff = new DataSet();
            //open conn
            OpenConnection();

            //create the table adapter using the connection string and the sql statement
            sqlAdapter = new SqlDataAdapter(sqlStatement, dBConnectionString);

            //fills in the data set
            sqlAdapter.Fill(dsStaff);

            //close conn
            CloseConnection();
            return dsStaff;
}

        public void RecordInDBStaff(string name, string surname, string gender, string staffid, string password, 
                               string staffrole, string dob, byte[] staffImage)            
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
            command.Parameters.Add(new SqlParameter("StaffPhoto", staffImage));

            OpenConnection();
            command.Connection = sqlconn;

            //execute the command
            int noRows = command.ExecuteNonQuery();

            CloseConnection();

        }

        public void SearchRec(string searchby)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its properties
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.Insert; //set the sql query
                   
            command.Parameters.Add(new SqlParameter("Surname", searchby));

            OpenConnection();
            command.Connection = sqlconn;

            //execute the command
            int noRows = command.ExecuteNonQuery();

            CloseConnection();

        }
        public void RecordInDBPatient(string patientid, string patientfullname, DateTime patientdob, byte [] patientphoto,  string patientgender,
                               string patientcondition, string readingmodule1, string readingmodule2, string readingmodule3, string readingmodule4)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its propertie
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.InsertPatient; //set the sql query
            command.Parameters.Add(new SqlParameter("PatientID", patientid));
            command.Parameters.Add(new SqlParameter("PatientFullname", patientfullname));
            command.Parameters.Add(new SqlParameter("PatientDOB", patientdob));
            command.Parameters.Add(new SqlParameter("PatientPhoto", patientphoto));
            command.Parameters.Add(new SqlParameter("PatientGender", patientgender));
            command.Parameters.Add(new SqlParameter("PatientCondition", patientcondition));
            command.Parameters.Add(new SqlParameter("ReadingModule1", readingmodule1));
            command.Parameters.Add(new SqlParameter("ReadingModule2", readingmodule2));
            command.Parameters.Add(new SqlParameter("ReadingModule3", readingmodule3));
            command.Parameters.Add(new SqlParameter("ReadingModule4", readingmodule4));
            OpenConnection();
            command.Connection = sqlconn;
            //execute the command
            int noRows = command.ExecuteNonQuery();

            CloseConnection();

        }







        public void UpdateInDBPatient(string patientid, string patientfullname, DateTime patientdob, byte[] patientphoto, 
                               string patientcondition, string readingmodule1, string readingmodule2, string readingmodule3, string readingmodule4)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its propertie
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.UpdatePatient; //set the sql query
            command.Parameters.Add(new SqlParameter("PatientID", patientid));
            command.Parameters.Add(new SqlParameter("PatientFullname", patientfullname));
            command.Parameters.Add(new SqlParameter("PatientDOB", patientdob));
            command.Parameters.Add(new SqlParameter("PatientPhoto", patientphoto));
            command.Parameters.Add(new SqlParameter("PatientCondition", patientcondition));
            command.Parameters.Add(new SqlParameter("ReadingModule1", readingmodule1));
            command.Parameters.Add(new SqlParameter("ReadingModule2", readingmodule2));
            command.Parameters.Add(new SqlParameter("ReadingModule3", readingmodule3));
            command.Parameters.Add(new SqlParameter("ReadingModule4", readingmodule4));
            OpenConnection();
            command.Connection = sqlconn;
            //execute the command
            int noRows = command.ExecuteNonQuery();

            CloseConnection();

        }





        public void DeleteFromPatient(string patientid)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its propertie
            command.CommandType = CommandType.Text;
            command.CommandText = Constants.Delete; //set the sql query
            command.Parameters.Add(new SqlParameter("PatientID", patientid));
            OpenConnection();
            command.Connection = sqlconn;
            //execute the command
            int noRows = command.ExecuteNonQuery();
            CloseConnection();

        }
    }
}