using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsPeople_DataAccess {

        static public DataTable GetAllPeople() { 
            
            DataTable dt = new DataTable();

            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPeople", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            while (Reader.HasRows)
                            {

                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }
            catch (Exception Ex) {

                Console.WriteLine("Database connection error: " + Ex.Message);
            }
            return dt;
        }
        static public int AddNewPerson(string FirstName, string LastName, string Email, string Phone) {

            int NewPersonID = -1;


            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        Command.Parameters.AddWithValue("@LastName", LastName);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);

                        SqlParameter outputIDparam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewPersonID = (int)Command.Parameters["@NewPersonID"].Value;
                    }
                }


            }
            catch (Exception Ex) {

                NewPersonID = -1;
            }

         
            return NewPersonID;
        }
        static public bool UpdatePerson(int PersonID, string FirstName, string LastName, string Email, string Phone) {

            int RowAffected = 0;
            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        RowAffected = (int)command.ExecuteNonQuery();
                    }
                }
                
            }
            catch (Exception Ex) {

                RowAffected = 0;
            }
            return (RowAffected > 0);
        }
        static public bool GetPersonByID(int PersonID, ref string FirstName, ref string LastName, ref string Email, ref string Phone) {

            bool IsFound = false;
            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                FirstName = Reader["FirstName"].ToString();
                                LastName = Reader["LastName"].ToString();
                                Email = Reader["Email"].ToString();
                                Phone = Reader["Phone"].ToString();
                            }
                            else
                            {

                                IsFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception Ex) {

                IsFound = false;
            }
                return IsFound;
        }
        static public bool DeletePerson(int PersonID) {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeletePerson", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        RowAffected = (int)command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {

                RowAffected = 0;
            }
            return (RowAffected > 0);

        }
    }
}
