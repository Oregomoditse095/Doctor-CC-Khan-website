using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using static Dr_CC_Khan.Pages.InWebPages.DoctorHomeModel;
using static Dr_CC_Khan.Pages.InWebPages.PatientHomeModel;

namespace Dr_CC_Khan.Pages.InWebPages
{
    public class ChronicModel : PageModel
    {
        public Diary diary = new Diary();
        public List<Appointment> appointment = new List<Appointment>();

        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            try
            { //to view appointment
                string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string sql = "SELECT * FROM APPOINTMENT";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                Appointment appoint = new Appointment();

                                appoint.name = read.GetString(0);
                                appoint.surname = read.GetString(1);
                                appoint.date = read.GetDateTime(2).ToString();
                                appoint.time = read.GetDateTime(3).ToString();
                                appoint.details = read.GetString(4);
                                appoint.age = "" + read.GetInt32(5);

                                appointment.Add(appoint);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void OnPost()
        {
            diary.Date = Request.Form["date"];
            diary.Symptoms = Request.Form["symp"];
            diary.Mood = Request.Form["feel"];

            if (diary.Date.Length == 0 || diary.Symptoms.Length == 0
                || diary.Mood.Length == 0)
            {
                errorMessage = "Non-optional fields must be filled";
                return;
            }

            //save the new disaster in the DB

            try
            {
                String connectionString = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO DIARY VALUES " +
                        "(@D_DATE, @SYMPTOMS, @T_AND_F);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@D_DATE", diary.Date);
                        command.Parameters.AddWithValue("@SYMPTOMS", diary.Symptoms);
                        command.Parameters.AddWithValue("@T_AND_F", diary.Mood);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            diary.Date = ""; diary.Symptoms = ""; diary.Mood = "";

            Response.Redirect("/InWebPages/Enquiry");
        }
    }
    
}
