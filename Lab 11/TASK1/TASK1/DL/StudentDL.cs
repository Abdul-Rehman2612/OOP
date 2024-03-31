using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TASK1.BL;
using TASK1.Utility;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TASK1.DL
{
    internal class StudentDL
    {
        static string Connection = "Server=DESKTOP-L60GA3Q;Database=STUDENTDATA;Trusted_Connection=True;";
        public static void AddStudent(Student s)
        {
            if (Validations.NameInputCheck(s.GetName())=="True")
            {
                if (Validations.IsValidNumber(s.GetAge()) && s.GetAge()!="")
                {
                    if (Validations.IsValidNumber(s.GetMarks()) && s.GetMarks()!= "")
                        using (SqlConnection sqlConnection = new SqlConnection(Connection))
                        {
                            string Query = $"INSERT INTO STUDENT(Name,Age,FscMarks) VALUES(@N,@A,@M);";
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                                cmd.Parameters.AddWithValue("@N", s.GetName());
                                cmd.Parameters.AddWithValue("@A", Convert.ToInt32(s.GetAge()));
                                cmd.Parameters.AddWithValue("@M", Convert.ToInt32(s.GetMarks()));
                                int rowsEffected = cmd.ExecuteNonQuery();
                                if (rowsEffected>0)
                                {
                                    MessageBox.Show("Student added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlConnection.Close();
                            }
                        }
                    else
                    {
                        MessageBox.Show("Marks must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Age must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(Validations.NameInputCheck(s.GetName()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteStudent(int Key)
        {
            string Query = $"DELETE STUDENT WHERE ID=@KEY";
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@KEY", Key);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Student deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public static void UpdateStudent(int Key,Student s)
        {
            if (Validations.NameInputCheck(s.GetName())=="True")
            {
                if (Validations.IsValidNumber(s.GetAge()) && s.GetAge()!="")
                {
                    if (Validations.IsValidNumber(s.GetAge()) && s.GetAge()!="")
                        using (SqlConnection sqlConnection = new SqlConnection(Connection))
                        {
                            string Query = $"UPDATE STUDENT SET Name=@NInput,Age=@AInput,FscMarks=@MInput WHERE ID=@Key;";
                            try
                            {
                                sqlConnection.Open();
                                SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                                cmd.Parameters.AddWithValue("@NInput", s.GetName());
                                cmd.Parameters.AddWithValue("@AInput", Convert.ToInt32(s.GetAge()));
                                cmd.Parameters.AddWithValue("@MInput", Convert.ToInt32(s.GetMarks()));
                                cmd.Parameters.AddWithValue("@Key", Key);
                                int rowsEffected = cmd.ExecuteNonQuery();
                                if (rowsEffected>0)
                                {
                                    MessageBox.Show("Student updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlConnection.Close();
                            }
                        }
                    else
                    {
                        MessageBox.Show("Marks must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Age must consist of numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(Validations.NameInputCheck(s.GetName()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
