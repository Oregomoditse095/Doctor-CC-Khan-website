using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Dr_CC_Khan.Pages.InWebPages
{
    public class RegisterModel : PageModel
    {

        public List<Register> register = new List<Register>();
        public Register reg = new Register();

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            reg.uEmail = Request.Form["email"];
            reg.uName = Request.Form["name"];
            reg.uSurname = Request.Form["surname"];
            reg.condition = Request.Form["illness"];
            reg.uPassword = Request.Form["confirm"];

            try
            {
                string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    String sql = "INSERT INTO PATIENT VALUES " +
                        "(@EMAIL, @P_NAME, @P_SURNAME, @CONDITION, @P_PASS);";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        command.Parameters.AddWithValue("@EMAIL", reg.uEmail);
                        command.Parameters.AddWithValue("@P_NAME", reg.uName);
                        command.Parameters.AddWithValue("@P_SURNAME", reg.uSurname);
                        command.Parameters.AddWithValue("@CONDITION", reg.condition);
                        command.Parameters.AddWithValue("@P_PASS", reg.uPassword);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public class Register
        {
            public string uEmail { get; set; }
            public string uName { get; set; }
            public string uSurname { get; set; }
            public string condition { get; set; }
            public string uPassword { get; set; }
        }
    }
}
