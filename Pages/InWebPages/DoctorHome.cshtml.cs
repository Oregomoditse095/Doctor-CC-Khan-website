using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Dr_CC_Khan.Pages.InWebPages
{
    public class DoctorHomeModel : PageModel
    {

        public List<Diary> diary = new List<Diary>();
        public List<Medical_Record> med_rec = new List<Medical_Record>();

        public void OnGet()
        {
            try
            { //to view appointment
                string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string sql = "SELECT * FROM DIARY";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                Diary note = new Diary();

                                note.Email = read.GetString(0);
                                note.Date = read.GetString(1);
                                note.Symptoms = read.GetString(2);
                                note.Mood = read.GetDateTime(3).ToString();

                                diary.Add(note);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            try
            { //to view appointment
                string connection = "Data Source=\\LAPTOP-9CVOGNKP;Initial Catalog=DrKhanDatabase;Integrated Security=True";

                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string sql = "SELECT * FROM MED_REC";

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                Medical_Record m_rec = new Medical_Record();

                                m_rec.id = "" + read.GetString(0);
                                m_rec.pEmail = read.GetString(1);
                                m_rec.illness = read.GetString(2);
                                m_rec.consult_date = read.GetDateTime(3).ToString();

                                med_rec.Add(m_rec);
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

        public class Diary
        {
            public string Email { get; set; }
            public string Date { get; set; }
            public string Symptoms { get; set; }
            public string Mood { get; set; }
        }

        public class Medical_Record
        {
            public string id { get; set; }
            public string pEmail { get; set; }
            public string illness { get; set; }
            public string consult_date { get; set; }
        }
    }
}
