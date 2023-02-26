using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Dr_CC_Khan.Pages.InWebPages
{
    public class PatientHomeModel : PageModel
    {

        public List<Appointment> appointment = new List<Appointment>();

        public void OnGet()
        {
            try { //to view appointment
            string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";
                 
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string sql = "SELECT * FROM APPOINTMENT" ;

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
            catch (Exception ex) {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public class Appointment
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string age { get; set; }
            public string email { get; set; }
            public string date { get; set; }
            public string time { get; set; }
            public string details { get; set; }
        }

        
    }
}
