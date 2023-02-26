using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Dr_CC_Khan.Pages.InWebPages
{
    public class SignInModel : PageModel
    {
        public void OnGet()
        {

        }

        public void onPost()
        {
            string email = Request.Form["userEmail"];
            string password = Request.Form["userPassword"];

            string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string sql = "SELECT * FROM PATIENT, DOCTOR";

                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string eml = Convert.ToString(read["EMAIL"]);
                            string pwd = Convert.ToString(read["P_PASS"]);
                            string con = Convert.ToString(read["CONDITION"]);
                            string dr = Convert.ToString(read["D_EMAIL"]);

                            if (email == eml && password == pwd)
                            {
                                if (con == "chronic")
                                {
                                    Response.Redirect("/InWebPages/Chronic");
                                }
                                else if (dr == "surgery@drcckhan.co.za")
                                {
                                    Response.Redirect("/InWebPages/DoctorHome");
                                }
                                else
                                    Response.Redirect("/InWebPages/PatientHome");
                            }
                            else
                                Response.Redirect("/InWebPages/ErrorPage");
                        }
                    }
                }
            }
        }
    }
}
