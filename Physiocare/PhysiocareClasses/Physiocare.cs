using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physiocare.PhysiocareClasses
{
    class Physiocare
    {
        // Getters and Setters properties for all the fields mentioned in the app
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string PatientProblem { get; set; }
        public string BriefHistory { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int PerSessionCost { get; set; }
        public string Notes { get; set; }
        public string ReferredBy { get; set; }
        public int Patient_ID { get; set; }
        public DateTime Date { get; set; }
        public int TotalVisit { get; set; }
        public int TotalCharges { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BillNumber { get; set; }





        //Defining connection with DB
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //Selecting data from Patient table

        public DataTable SelectPatient()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                // Writting SQL Query
                string sql = "SELECT * FROM PATIENT";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }

            catch(Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }

            return dt;
        }


        //Method to insert data into Patient table
        public bool InsertPatient(Physiocare c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Creating query to insert data into patient table
                string sql = "INSERT INTO PATIENT (First_Name, Middle_Name, Last_Name, Age, Gender, Contact_Number, Email_ID, Address, Patient_Problem, Brief_History, Referred_By, Per_Session_Cost, Notes, Weight, Height, Start_Date) VALUES (@FirstName, @MiddleName, @LastName, @Age, @Gender, @ContactNumber, @EmailID, @Address, @PatientProblem, @BriefHistory, @ReferredBy, @PerSessionCost, @Notes, @Weight, @Height, cast(GETDATE() as Date))";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating Paramenters to add data to the query
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@EmailID", c.EmailID);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@PatientProblem", c.PatientProblem);
                cmd.Parameters.AddWithValue("@BriefHistory", c.BriefHistory);
                cmd.Parameters.AddWithValue("@Height", c.Height);
                cmd.Parameters.AddWithValue("@Weight", c.Weight);
                cmd.Parameters.AddWithValue("@PerSessionCost", c.PerSessionCost);
                cmd.Parameters.AddWithValue("@Notes", c.Notes);
                cmd.Parameters.AddWithValue("@ReferredBy", c.ReferredBy);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Checking if the query is completed successfully by taking the count of rows, 
                //if rows is greater than 0 then query is successfully loaded the data and hence we will set the bool variable to true

                if(rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool UpdatePatient(Physiocare c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Creating query to update data into patient table
                string sql = "UPDATE PATIENT SET First_Name=@FirstName, Middle_Name=@MiddleName, Last_Name=@LastName, Age=@Age, Gender=@Gender, Contact_Number=@ContactNumber, Email_ID=@EmailID, Address=@Address, Patient_Problem=@PatientProblem, Brief_History=@BriefHistory, Referred_By=@ReferredBy, Per_Session_Cost=@PerSessionCost, Notes=@Notes, Weight=@Weight, Height=@Height WHERE Patient_ID=@PatientID";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating Paramenters to add data to the query
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@EmailID", c.EmailID);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@PatientProblem", c.PatientProblem);
                cmd.Parameters.AddWithValue("@BriefHistory", c.BriefHistory);
                cmd.Parameters.AddWithValue("@Height", c.Height);
                cmd.Parameters.AddWithValue("@Weight", c.Weight);
                cmd.Parameters.AddWithValue("@PerSessionCost", c.PerSessionCost);
                cmd.Parameters.AddWithValue("@Notes", c.Notes);
                cmd.Parameters.AddWithValue("@PatientID", c.Patient_ID);
                cmd.Parameters.AddWithValue("@ReferredBy", c.ReferredBy);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Checking if the query is completed successfully by taking the count of rows, 
                //if rows is greater than 0 then query is successfully loaded the data and hence we will set the bool variable to true

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to delete the record of patient
        public bool DeletePatient(Physiocare c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Creating query to delete record from patient table
                string sql = "DELETE FROM PATIENT WHERE Patient_ID=@PatientID";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating Paramenters to add data to the query
                cmd.Parameters.AddWithValue("@PatientID", c.Patient_ID);

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Checking if the query is completed successfully by taking the count of rows, 
                //if rows is greater than 0 then query has successfully deleted the record and hence we will set the bool variable to true

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Method to insert data into Attendance table
        public bool InsertAttendance(Physiocare c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Creating query to insert data into patient table
                string sql = "INSERT INTO Attendance (Patient_ID, First_Name, Last_Name, Date) VALUES (@Patient_ID, @FirstName, @LastName, @Date)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating Paramenters to add data to the query
                cmd.Parameters.AddWithValue("@Patient_ID", c.Patient_ID);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Date", c.Date);
                

                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Checking if the query is completed successfully by taking the count of rows, 
                //if rows is greater than 0 then query is successfully loaded the data and hence we will set the bool variable to true

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Selecting total count of attendance for billing
        public DataTable SelectAttendace()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            

            try
            {
                // Writting SQL Query
                string sql = "SELECT COUNT(1) Total FROM Attendance WHERE PATIENT_ID = '" + Patient_ID + "'";
                //string sql = "SELECT COUNT(*) Total FROM Attendance";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                //SqlDataReader sqlDataReader = cmd.ExecuteReader();
                //Count = (int)(sqlDataReader.GetValue(0));
                foreach(DataRow row in dt.Rows)
                {
                    TotalVisit = int.Parse(row["Total"].ToString());
                }
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }

            return dt;
        }


        //Method to insert data into Billing table
        public bool InsertBilling(Physiocare c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Creating query to insert data into patient table
                string sql = "INSERT INTO BILLING (Patient_ID, First_Name, Middle_Name, Last_Name, Patient_Problem, Total_Visits, Total_Charges, Bill_Date, Bill_Number) VALUES (@Patient_ID, @FirstName, @MiddleName, @LastName, @PatientProblem, @TotalVisit, @TotalCharges, cast(GETDATE() as Date), @BillNumber)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating Paramenters to add data to the query
                cmd.Parameters.AddWithValue("@Patient_ID", c.Patient_ID);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@PatientProblem", c.PatientProblem);
                cmd.Parameters.AddWithValue("@TotalVisit", c.TotalVisit);
                cmd.Parameters.AddWithValue("@TotalCharges", c.TotalCharges);
                cmd.Parameters.AddWithValue("@BillNumber", c.BillNumber);
                
                //Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //Checking if the query is completed successfully by taking the count of rows, 
                //if rows is greater than 0 then query is successfully loaded the data and hence we will set the bool variable to true

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


    }
}
