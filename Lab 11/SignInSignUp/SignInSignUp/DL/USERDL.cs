using System;
using SignInSignUp.BL;
using SignInSignUp.UTILITY;
using System.Data.SqlClient;
namespace SignInSignUp.DL
{
    internal class USERDL
    {
        static string Connection = "Server=DESKTOP-L60GA3Q;Database=USERDATA;Trusted_Connection=True;";
        public static string SIGNUP(USER u)
        {
            string message = VALIDATIONS.UsernameValidation(u.GetUserName());
            if (message==u.GetUserName())
            {
                message=VALIDATIONS.PasswordValidation(u.GetPassword());
                if (message==u.GetPassword())
                {
                    if (!Usercheck(u))
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(Connection))
                        {
                            string Query = $"INSERT INTO USERBL(Username,Password) VALUES(@UN,@UP)";
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                                cmd.Parameters.AddWithValue("@UN", u.GetUserName());
                                cmd.Parameters.AddWithValue("@UP", u.GetPassword());
                                int rowsEffected = cmd.ExecuteNonQuery();
                                if (rowsEffected>0)
                                {
                                    message = "User added successfully!";
                                }
                            }
                            catch (Exception ex)
                            {
                                message = ex.Message;
                            }
                            finally
                            {
                                sqlConnection.Close();
                            }
                        }
                    }
                    else
                    {
                        message="User already exists!";
                    }
                }
            }
            return message;
        }
        public static string SIGNIN(USER u)
        {
            if(Usercheck(u))
            {
                return "Signed In successfully!";
            }
            else
            {
                return "User not found! Sign up in case of new user!";
            }
        }
        public static bool Usercheck(USER u)
        {
            bool check = false;
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "SELECT * FROM USERBL WHERE Username=@UN and Password=@UP";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@UN", u.GetUserName());
                    cmd.Parameters.AddWithValue("@UP", u.GetPassword());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        check= true;
                    }
                }
                catch (Exception)
                {
                    check = true;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return check;
        }
    }
}
